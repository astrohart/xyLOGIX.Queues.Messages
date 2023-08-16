using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;
using xyLOGIX.Queues.Messages.Items.Interfaces;

namespace xyLOGIX.Queues.Messages.Items.Extensions
{
    /// <summary>
    /// Provides extension methods that are designed to make working with
    /// instances of objects implementing the
    /// <see
    ///     cref="T:xyLOGIX.Queues.Messages.Interfaces.IMessageQueueItem" />
    /// interface more fluent.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class MessageQueueItemExtensions
    {
        /// <summary>
        /// Determines whether the specified message queue
        /// <paramref name="item" />has a data object whose type matches that of
        /// <typeparamref name="T" />.
        /// </summary>
        /// <typeparam name="T">Name of the class that carries the message data.</typeparam>
        /// <param name="item">
        /// Reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem" /> interface that represents the
        /// message queue item to be checked.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the event data type of the provided
        /// <paramref name="item" /> matches; <see langword="false" /> otherwise.
        /// </returns>
        public static bool DoesEventDataTypeMatch<T>(
            this IMessageQueueItem item
        )
        {
            var result = false;

            try
            {
                if (item == null) return result;
                if (item.EventDataType == null) return result;

                result = item.EventDataType == typeof(T);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        /// <summary>
        /// Determines whether a message queue <paramref name="item" /> has data
        /// of type <typeparamref name="T" /> and corresponds to the message ID specified
        /// by the <paramref name="messageId" /> parameter.
        /// </summary>
        /// <typeparam name="T">
        /// Name of the class that contains the message queue item's
        /// data.
        /// </typeparam>
        /// <param name="item">
        /// Reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem" /> interface that represents the
        /// message queue item to be checked.
        /// </param>
        /// <param name="messageId">
        /// A <see cref="T:System.Guid" /> indicating who should
        /// receive the message.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the message queue <paramref name="item" />
        /// is bound for the message ID with the specified <paramref name="messageId" />;
        /// <see langword="false" /> otherwise.
        /// </returns>
        public static bool IsBoundToMessageId<T>(
            this IMessageQueueItem item,
            Guid messageId
        )
        {
            var result = false;

            try
            {
                if (item == null) return result;
                if (messageId.IsZero()) return result;
                if (item.EventDataType != typeof(T)) return result;
                if (item.MessageHandler == null) return result;

                result = item.MessageId == messageId;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        /// <summary>
        /// Determines whether a message queue <paramref name="item" /> has data
        /// of type <typeparamref name="T" /> and corresponds to the message ID specified
        /// by the <paramref name="messageId" /> parameter.
        /// </summary>
        /// <typeparam name="T">
        /// Name of the class that contains the message queue item's
        /// data.
        /// </typeparam>
        /// <typeparam name="R">
        /// Name of the class that contains the message queue item's
        /// result.
        /// </typeparam>
        /// <param name="item">
        /// Reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem" /> interface that represents the
        /// message queue item to be checked.
        /// </param>
        /// <param name="messageId">
        /// A <see cref="T:System.Guid" /> indicating who should
        /// receive the message.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the message queue <paramref name="item" /> is bound
        /// for the message ID with the specified <paramref name="messageId" />;
        /// <see langword="false" /> otherwise.
        /// </returns>
        public static bool IsBoundToMessageId<T, R>(
            this IMessageQueueItem item,
            Guid messageId
        )
        {
            var result = false;

            try
            {
                if (item == null) return result;
                if (messageId.IsZero()) return result;
                if (item.EventDataType != typeof(T)) return result;
                if (item.ResultDataType != typeof(R)) return result;

                result = item.MessageId == messageId;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        /// <summary>
        /// Determines whether a message queue <paramref name="item" /> corresponds to the
        /// message ID specified by the <paramref name="messageId" /> parameter.
        /// </summary>
        /// <param name="item">
        /// Reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem" /> interface that represents the
        /// message queue item to be checked.
        /// </param>
        /// <param name="messageId">
        /// A <see cref="T:System.Guid" /> indicating who should receive the message.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the message queue <paramref name="item" /> is bound
        /// for the message ID with the specified <paramref name="messageId" />;
        /// <see langword="false" /> otherwise.
        /// </returns>
        public static bool IsBoundToMessageId(
            this IMessageQueueItem item,
            Guid messageId
        )
        {
            var result = false;

            try
            {
                if (item == null) return result;
                if (messageId.IsZero()) return result;

                result = item.MessageId == messageId;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }
    }
}