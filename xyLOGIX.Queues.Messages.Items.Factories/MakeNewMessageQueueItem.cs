using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Queues.Messages.Items.Interfaces;

namespace xyLOGIX.Queues.Messages.Items.Factories
{
    /// <summary>
    /// Creates new message queue item objects.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class MakeNewMessageQueueItem
    {
        /// <summary>
        /// Creates a new instance of a message queue item object that
        /// implements the
        /// <see cref="T:xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem" />
        /// interface
        /// and associates it with the specified event data <see cref="T:System.Type" />.
        /// </summary>
        /// <param name="eventDataType">
        /// (Required.) Reference to an instance of <see cref="T:System.Type" />
        /// that specifies the data type of the event data object that is
        /// associated with this event.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem" />
        /// interface.
        /// </returns>
        /// <remarks>
        /// After calling this method, callers must then invoke the
        /// <see
        ///     cref="M:SampleMVP.MessageQueueItem.AndHandler" />
        /// method to associate
        /// the event data type specified with the code that is to be executed
        /// when the message is posted to the queue.
        /// </remarks>
        public static IMessageQueueItem ForEventDataType(Type eventDataType)
        {
            IMessageQueueItem result = default;

            try
            {
                if (eventDataType == null) return result;

                result = new MessageQueueItem { EventDataType = eventDataType };
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = default;
            }

            return result;
        }

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Queues.Messages.Interfaces.IMessageQueueItem" />
        /// interface and which is totally uninitialized.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.Queues.Messages.Interfaces.IMessageQueueItem" />
        /// interface.
        /// </returns>
        public static IMessageQueueItem FromScratch()
            => new MessageQueueItem();
    }
}