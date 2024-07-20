using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;
using xyLOGIX.Queues.Messages.Comparers.Factories;
using xyLOGIX.Queues.Messages.Interfaces;
using xyLOGIX.Queues.Messages.Items.Extensions;
using xyLOGIX.Queues.Messages.Items.Factories;
using xyLOGIX.Queues.Messages.Items.Interfaces;

namespace xyLOGIX.Queues.Messages
{
    /// <summary> Centralized storehouse for application messages. </summary>
    [Log(AttributeExclude = true)]
    public class MessageQueue : IMessageQueue
    {
        /// <summary> Synchronization context object. </summary>
        private static readonly object SyncRoot = new object();

        /// <summary> Internal message queue. </summary>
        private readonly IList<IMessageQueueItem> _internalMessageQueue =
            new List<IMessageQueueItem>();

        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this
        /// class.
        /// </summary>
        static MessageQueue() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this
        /// class.
        /// </summary>
        protected MessageQueue() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that
        /// implements the
        /// <see cref="T:xyLOGIX.Queues.Messages.Interfaces.IMessageQueue" /> interface.
        /// </summary>
        public static IMessageQueue Instance { get; } = new MessageQueue();

        /// <summary>
        /// Broadcasts a message to all subscribers everywhere in the
        /// application.
        /// </summary>
        /// <typeparam name="T"> Name of the class containing the message's data. </typeparam>
        /// <param name="args">
        /// Zero or more arguments to be provided to the message
        /// handler.
        /// <para />
        /// <b>NOTE:</b> The number, order, and type of arguments provided must match the
        /// message delegate's signature precisely.
        /// </param>
        public void BroadcastMessage<T>(params object[] args)
        {
            lock (SyncRoot)
            {
                try
                {
                    if (_internalMessageQueue == null) return;
                    if (!_internalMessageQueue.Any()) return;
                    if (!_internalMessageQueue.Any(
                            item => item.DoesEventDataTypeMatch<T>()
                        ))
                        return;

                    foreach (var item in _internalMessageQueue.Where(
                                 item => item.DoesEventDataTypeMatch<T>()
                             ))
                    {
                        if (item?.MessageHandler == null) continue;
                        if (item.MessageId.IsZero()) continue;

                        item.MessageHandler.DynamicInvoke(args);
                    }
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);
                }
            }
        }

        /// <summary>
        /// Associates event data with the message handler, i.e., the method that
        /// contains the code to be executed when the message is posted to the queue.
        /// </summary>
        /// <typeparam name="T"> Name of the type of the event data. </typeparam>
        /// <param name="messageHandler">
        /// A <see cref="T:System.Delegate" /> that specifies
        /// the code to be executed when the message is posted to the queue.
        /// </param>
        /// <remarks>
        /// A message that is mapped to a handler using this method will be
        /// broadcast, i.e., any component of the application that registers a handler will
        /// automatically have its handler invoked.
        /// </remarks>
        public void MapMessage<T>(Delegate messageHandler)
        {
            lock (SyncRoot)
            {
                try
                {
                    if (messageHandler == null) return;
                    if (_internalMessageQueue == null) return;
                    if (_internalMessageQueue.Any(
                            message => messageHandler.Equals(
                                message.MessageHandler
                            )
                        ))
                        return; // message is already mapped

                    // Add the message to the message map Basically, you are telling
                    // me that, when a message of type T is posted to the queue,
                    // then call the code referenced by the messageHandler.
                    var item = MakeNewMessageQueueItem
                               .ForEventDataType(typeof(T))
                               .AndHandler(messageHandler)
                               .WithDisposalAction(Remove);

                    /*
                     * Specific mappings, between specific methods and specific event
                     * identifiers, can only be added once.
                     */
                    if (!_internalMessageQueue.Contains(
                            item,
                            GetMessageQueueItemEquialityComparer.That
                                .TakesEventDataTypeIntoAccount()
                        ))
                        _internalMessageQueue.Add(item);
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);
                }
            }
        }

        /// <summary>
        /// Associates a unique identifier with the code to be executed when the
        /// message is posted to the queue, with no regard for the event data type.
        /// </summary>
        /// <param name="messageId">
        /// (Required.) A <see cref="T:System.Guid" /> indicating
        /// the specific application object that should process the message.
        /// </param>
        /// <param name="messageHandler">
        /// s A <see cref="T:System.Delegate" /> that
        /// specifies the code to be executed when the message is posted to the queue.
        /// </param>
        public void MapMessage(Guid messageId, Delegate messageHandler)
        {
            lock (SyncRoot)
            {
                try
                {
                    if (messageId.IsZero()) return;
                    if (messageHandler == null) return;
                    if (_internalMessageQueue == null) return;
                    if (_internalMessageQueue.Any(
                            message => messageId.Equals(message.MessageId)
                        ))
                        return; // message is already mapped

                    // Add the message to the message map. Basically, you are
                    // telling me that, when a message of type T, with Message ID
                    // messageId is posted to the queue, then execute the code
                    // referred to by the messageHandler delegate.
                    _internalMessageQueue.Add(
                        MakeNewMessageQueueItem.FromScratch()
                                               .HavingMessageId(messageId)
                                               .AndHandler(messageHandler)
                                               .WithDisposalAction(Remove)
                    );
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);
                }
            }
        }

        /// <summary>
        /// Associates event data with the message handler, i.e., the method that
        /// contains the code to be executed when the message is posted to the queue.
        /// </summary>
        /// <typeparam name="T"> Name of the type of the event data. </typeparam>
        /// <param name="messageId">
        /// (Required.) A <see cref="T:System.Guid" /> indicating
        /// the specific application object that should process the message.
        /// </param>
        /// <param name="messageHandler">
        /// A <see cref="T:System.Delegate" /> that specifies
        /// the code to be executed when the message is posted to the queue.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the Zero GUID is passed
        /// for the <paramref name="messageId" /> parameter.
        /// </exception>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="messageHandler" />, is passed a
        /// <see langword="null" /> value.
        /// </exception>
        public void MapMessage<T>(Guid messageId, Delegate messageHandler)
        {
            lock (SyncRoot)
            {
                try
                {
                    if (messageId.IsZero()) return;
                    if (messageHandler == null) return;
                    if (_internalMessageQueue == null) return;
                    if (_internalMessageQueue.Any(
                            message => messageId.Equals(message.MessageId) &&
                                       typeof(T) == message.EventDataType
                        ))
                        return; // message is already mapped

                    // Add the message to the message map. Basically, you are
                    // telling me that, when a message of type T, with Message ID
                    // messageId is posted to the queue, then execute the code
                    // referred to by the messageHandler delegate.
                    _internalMessageQueue.Add(
                        MakeNewMessageQueueItem.ForEventDataType(typeof(T))
                                               .HavingMessageId(messageId)
                                               .AndHandler(messageHandler)
                                               .WithDisposalAction(Remove)
                    );
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);
                }
            }
        }

        /// <summary>
        /// Posts a message to the message queue and aims it at the specific
        /// message ID indicated by the <paramref name="messageId" />. Only the objects who
        /// originally mapped handlers to the message with the specified message ID will be
        /// sent the message.
        /// </summary>
        /// <typeparam name="T">
        /// Name of the type of data that will be passed to the
        /// message handler.
        /// </typeparam>
        /// <param name="messageId">
        /// A <see cref="T:System.Guid" /> indicating who should
        /// receive the message.
        /// </param>
        /// <param name="args">
        /// Zero or more arguments to be provided to the message
        /// handler.
        /// <para />
        /// <b>NOTE:</b> The number, order, and type of arguments provided must match the
        /// message delegate's signature precisely.
        /// </param>
        public void PostMessage<T>(Guid messageId, params object[] args)
        {
            lock (SyncRoot)
            {
                try
                {
                    // Dump the variable messageId to the log
                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"MessageQueue.PostMessage: messageId = '{messageId}'"
                    );

                    /*
                     * OKAY, check whether the messageId is the empty GUID. If so, then
                     * this method will devolve to a call to BroadcastMessage().
                     */
                    if (messageId.IsZero())
                    {
                        BroadcastMessage<T>(args);
                        return;
                    }

                    if (_internalMessageQueue == null) return;
                    if (!_internalMessageQueue.Any()) return;
                    if (!_internalMessageQueue.Any(
                            item => item.IsBoundToMessageId<T>(messageId)
                        ))
                        return;

                    foreach (var item in _internalMessageQueue.Where(
                                 item => item.IsBoundToMessageId<T>(messageId)
                             )) item.MessageHandler?.DynamicInvoke(args);
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);
                }
            }
        }

        /// <summary>
        /// Posts a message to the message queue and aims it at the specific
        /// message ID indicated by the <paramref name="messageId" />. Only the objects who
        /// originally mapped handlers to the message with the specified message ID will be
        /// sent the message.
        /// </summary>
        /// <param name="messageId">
        /// A <see cref="T:System.Guid" /> indicating who should
        /// receive the message.
        /// </param>
        /// <param name="args">
        /// Zero or more arguments to be provided to the message
        /// handler.
        /// <para />
        /// <b>NOTE:</b> The number, order, and type of arguments provided must match the
        /// message delegate's signature precisely.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the Zero GUID is passed
        /// for the <paramref name="messageId" /> parameter.
        /// </exception>
        public void PostMessage(Guid messageId, params object[] args)
        {
            lock (SyncRoot)
            {
                try
                {
                    if (messageId.IsZero()) return;
                    if (_internalMessageQueue == null) return;
                    if (!_internalMessageQueue.Any()) return;
                    if (!_internalMessageQueue.Any(
                            item => item.IsBoundToMessageId(messageId)
                        ))
                        return;

                    foreach (var item in _internalMessageQueue.Where(
                                 item => item.IsBoundToMessageId(messageId)
                             )) item.MessageHandler?.DynamicInvoke(args);
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);
                }
            }
        }

        /// <summary>
        /// Posts a message to the message queue and aims it at the specific
        /// message ID indicated by the <paramref name="messageId" />. Only the objects who
        /// originally mapped handlers to the message with the specified message ID will be
        /// sent the message.
        /// </summary>
        /// <typeparam name="T">
        /// Name of the type of data that will be passed to the
        /// message handler.
        /// </typeparam>
        /// <typeparam name="R">
        /// Name of the type of data that will be returned from the
        /// message handler as its result.
        /// </typeparam>
        /// <param name="messageId">
        /// A <see cref="T:System.Guid" /> indicating who should
        /// receive the message.
        /// </param>
        /// <param name="args">
        /// Zero or more arguments to be provided to the message
        /// handler.
        /// <para />
        /// <b>NOTE:</b> The number, order, and type of arguments provided must match the
        /// message delegate's signature precisely.
        /// </param>
        public R PostMessage<T, R>(Guid messageId, params object[] args)
        {
            lock (SyncRoot)
            {
                R result = default;

                try
                {
                    if (messageId.IsZero()) return result;
                    if (_internalMessageQueue == null) return result;
                    if (!_internalMessageQueue.Any()) return result;
                    if (!_internalMessageQueue.Any(
                            item => item.IsBoundToMessageId<T, R>(messageId)
                        ))
                        return result;

                    result = (R)_internalMessageQueue.First(
                            item => item.IsBoundToMessageId<T, R>(messageId)
                        )
                        .MessageHandler?.DynamicInvoke(args);
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);
                }

                return result;
            }
        }

        /// <summary>
        /// Removes the first occurrence of the specified
        /// <paramref name="item" /> from the message queue.
        /// </summary>
        /// <param name="item">
        /// (Required.) Reference to an instance of an object that
        /// implements the
        /// <see cref="T:xyLOGIX.Queues.Messages.Interfaces.IMessageQueueItem" /> interface
        /// and which represents the item to be removed.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="item" />, is passed a <see langword="null" /> value.
        /// </exception>
        private void Remove(IMessageQueueItem item)
        {
            try
            {
                if (item == null) return;
                if (_internalMessageQueue == null) return;
                if (!_internalMessageQueue.Any()) return;
                if (!_internalMessageQueue.Contains(item)) return;

                _internalMessageQueue.Remove(item);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}