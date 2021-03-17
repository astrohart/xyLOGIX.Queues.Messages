using System;
using xyLOGIX.Queues.Messages.Interfaces;

namespace xyLOGIX.Queues.Messages.Models
{
    /// <summary>
    /// Represents a single item in a
    /// <see cref="T:xyLOGIX.Queues.Messages.MessageQueue" />.
    /// </summary>
    public class MessageQueueItem : IMessageQueueItem
    {
        /// <summary>
        /// An <see cref="T:System.Action" /> that specifies how to remove this
        /// <c>MessageQueueItem</c> from the <c>MessageQueue</c>.
        /// </summary>
        private Action<IMessageQueueItem> _removalAction;

        /// <summary>
        /// Gets or sets the <see cref="T:System.Type" /> of the event data.
        /// </summary>
        public Type EventDataType { get; set; }

        /// <summary>
        /// Gets or sets a <see cref="T:System.Delegate" /> that specifies what
        /// code is to be run when a message is sent.
        /// </summary>
        public Delegate MessageHandler { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the message ID of this
        /// specific <c>MessageQueueItem</c>.
        /// </summary>
        /// <remarks>
        /// If this property is set to the zero GUID, then the message is broadcast.
        /// </remarks>
        public Guid MessageId { get; set; } = Guid.Empty;

        /// <summary>
        /// Fluent-builder method to associate this <c>MessageQueueItem</c> with
        /// code to be executed when the message is published.
        /// </summary>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="messageHandler" />,
        /// is passed a <c>null</c> value.
        /// </exception>
        public IMessageQueueItem AndHandler(Delegate messageHandler)
        {
            MessageHandler = messageHandler ??
                             throw new ArgumentNullException(
                                 nameof(messageHandler)
                             );

            return this;
        }

        /// <summary>
        /// Fluent-builder method to mark this <c>MessageQueueItem</c> for
        /// processing only by those objects who map handlers to a specific
        /// message ID.
        /// </summary>
        /// <param name="messageId">
        /// (Required.) A <see cref="T:System.Guid" /> tagging this message with
        /// a unique identifier.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <remarks>
        /// Calling this method is optional. The Zero GUID will be associated
        /// with this <c>MessageQueueItem</c> if this method is not called.
        /// <para />
        /// Associating a message with the Zero GUID means that the message in
        /// question should be dispatched to all interested parties.
        /// </remarks>
        public IMessageQueueItem HavingMessageId(Guid messageId)
        {
            MessageId = messageId;

            return this;
        }

        /// <summary>
        /// Fluent-builder method that enables us to attach a
        /// <see
        ///     cref="T:System.Action{xyLOGIX.Queues.Messages.Interfaces.IMessageQueueItem}" />
        /// to this object that is called when this object's resources are freed
        /// from memory by the garbage collector.
        /// <para />
        /// The most common implementation is to remove the newly-built
        /// <see cref="T:xyLOGIX.Queues.Messages.Interfaces.IMessageQueueItem" />
        /// -implementing object from the internal list maintained by the
        /// <c>MessageQueue</c> object.
        /// </summary>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        public IMessageQueueItem WithDisposalAction(
            Action<IMessageQueueItem> removalAction)
        {
            _removalAction = removalAction ??
                             throw new ArgumentNullException(
                                 nameof(removalAction)
                             );

            return this;
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing,
        /// releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
            => _removalAction?.Invoke(this);
    }
}