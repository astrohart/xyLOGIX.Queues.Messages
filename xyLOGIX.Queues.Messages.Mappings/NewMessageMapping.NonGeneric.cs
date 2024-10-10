using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Queues.Messages.Extensions;

namespace xyLOGIX.Queues.Messages.Mappings
{
    /// <summary> Fluent-builder object to build message-map entries. </summary>
    /// <remarks>
    /// Message-map entries are what bind together a message's identifier
    /// and/or data object type with a method that handles it; i.e, its message
    /// handler.
    /// <para />
    /// Message handlers are invoked automatically in response to messages being sent
    /// or broadcast with the corresponding identifier or data type specified.
    /// </remarks>
    [Log(AttributeExclude = true)]
    public class NewMessageMapping
    {
        /// <summary>
        /// Unique identifier that identifies the specific message that gets
        /// matched with a method that will be invoked when the message is sent.
        /// </summary>
        private Guid _messageId;

        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this
        /// class.
        /// </summary>
        static NewMessageMapping() { }

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:xyLOGIX.Queues.Messages.NewMessageMapping{T}" /> and returns a
        /// reference to it.
        /// </summary>
        protected NewMessageMapping() { }

        /// <summary> Associates a message and its handler together. </summary>
        public static NewMessageMapping Associate { get; } =
            new NewMessageMapping();

        /// <summary>
        /// Associates a <see cref="T:System.EventHandler" /> with the message
        /// having unique identifier specified by the earlier call to the
        /// <see cref="M:xyLOGIX.Queues.Messages.NewMessageMapping.WithMessageId" />
        /// method.
        /// </summary>
        /// <param name="handler">
        /// A <see cref="T:System.EventHandler" /> specifying the
        /// code to be invoked when the message is sent.
        /// </param>
        /// <remarks>
        /// The delegate, <paramref name="handler" />, can be thought of as being
        /// analogous to a C-style function pointer, in that it refers to code that will be
        /// invoked when a message matching the creation criteria is sent.
        /// <para />
        /// This method is not meant to be called in a standalone fashion; rather, it
        /// should be called in a fluent chain after calling the WithMessageId method.
        /// <para />
        /// It is not required, nor is it even advisable, to call the
        /// <see cref="M:xyLOGIX.Queues.Messages.NewMessageMapping.WithMessageId" /> method
        /// before calling this one. If this has been done anyway, then this method throws
        /// <see cref="T:System.InvalidOperationException" />.
        /// </remarks>
        public void AndEventHandler(EventHandler handler)
        {
            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** INFO: Mapping event handler to message '{_messageId}'..."
                );

                if (handler == null) return;
                if (Guid.Empty == _messageId) return;

                handler.MapToMessage(_messageId);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Associates a <see cref="T:System.Delegate" /> with the message having
        /// unique identifier specified by the earlier call to the
        /// <see cref="M:xyLOGIX.Queues.Messages.NewMessageMapping.WithMessageId" />
        /// method.
        /// </summary>
        /// <param name="d">
        /// A <see cref="T:System.Delegate" /> specifying the code to be
        /// invoked when the message is sent.
        /// </param>
        /// <remarks>
        /// The delegate, <paramref name="d" />, can be thought of as being
        /// analogous to a C-style function pointer, in that it refers to code that will be
        /// invoked when a message matching the creation criteria is sent.
        /// <para />
        /// This method is not meant to be called in a standalone fashion; rather, it
        /// should be called in a fluent chain after calling the WithMessageId method.
        /// <para />
        /// It is not required, nor is it even advisable, to call the
        /// <see cref="M:xyLOGIX.Queues.Messages.NewMessageMapping.WithMessageId" /> method
        /// before calling this one. If this has been done anyway, then this method throws
        /// <see cref="T:System.InvalidOperationException" />.
        /// </remarks>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="d" />, is passed a <see langword="null" /> value.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown if the
        /// <see cref="M:xyLOGIX.Queues.Messages.NewMessageMapping.WithMessageId" /> method
        /// has been called prior to calling this method.
        /// </exception>
        public void AndHandler(Delegate d)
        {
            if (d == null) throw new ArgumentNullException(nameof(d));
            if (Guid.Empty == _messageId)
                throw new InvalidOperationException(
                    "This method should be called in a fluent chain with the WithMessageId method."
                );
            d.MapToMessage(_messageId);
        }

        /// <summary>
        /// Associates a unique identifier, <paramref name="messageId" />, with a
        /// message handler.
        /// </summary>
        /// <param name="messageId">
        /// (Required.) A <see cref="T:System.Guid" /> that
        /// contains the unique identifier to assign to the message.
        /// <para />
        /// The Empty GUID is not allowed.
        /// </param>
        /// <returns> </returns>
        /// Reference to the same instance of the object that called this method, for fluent use.
        /// <remarks>
        /// <para />
        /// <b>NOTE:</b> You must call the
        /// <see cref="M:xyLOGIX.Queues.Messages.NewMessageMapping.AndHandler" /> method
        /// after calling this method. This method has to be called prior to calling the
        /// <see cref="M:xyLOGIX.Queues.Messages.NewMessageMapping.AndHandler" /> method.
        /// If this is not done, then the
        /// <see cref="M:xyLOGIX.Queues.Messages.NewMessageMapping.AndHandler" /> method
        /// will throw a <see cref="T:System.InvalidOperationException" /> exception.
        /// </remarks>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the
        /// <paramref name="messageId" /> parameter is passed
        /// <see cref="T:System.Guid.Empty" /> for its value.
        /// </exception>
        public NewMessageMapping WithMessageId(Guid messageId)
        {
            if (Guid.Empty == messageId)
                throw new ArgumentException(
                    "You may not pass the Zero GUID for the messageId parameter.",
                    nameof(messageId)
                );

            _messageId = messageId;

            return this;
        }
    }
}