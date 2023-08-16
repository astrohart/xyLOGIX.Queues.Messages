using PostSharp.Patterns.Diagnostics;
using System;
using System.Linq;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;
using xyLOGIX.Queues.Messages.Factories;
using xyLOGIX.Queues.Messages.Interfaces;

namespace xyLOGIX.Queues.Messages.Senders
{
    /// <summary>
    /// Sends messages to other application components, whose event data is of
    /// type specified.
    /// </summary>
    /// <typeparam name="T">
    /// Name of the type of data that the message notification will carry.
    /// </typeparam>
    /// <typeparam name="R">
    /// Name of the type of the object that the method processing
    /// the received message will return.
    /// </typeparam>
    [Log(AttributeExclude = true)]
    public class SendMessage<T, R>
    {
        /// <summary>
        /// Array of instances of objects that provide input to the notification.
        /// </summary>
        private object[] _args;

        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static SendMessage() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected SendMessage() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:SampleMVP.SendMessage" />.
        /// </summary>
        /// <remarks>
        /// This property is meant to be used in a fluent manner.
        /// <para />
        /// When using this property, first invoke the
        /// <see
        ///     cref="M:xyLOGIX.Queues.Messages.SendMessage.Args" />
        /// method and then
        /// the <see cref="M:xyLOGIX.Queues.Messages.SendMessage.ForMessageId" />
        /// method to send your message.
        /// </remarks>
        public static SendMessage<T, R> Having { get; } =
            new SendMessage<T, R>();

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.Queues.Messages.Interfaces.IMessageQueue" /> interface.
        /// </summary>
        private static IMessageQueue MessageQueue { get; } =
            GetMessageQueue.SoleInstance();

        /// <summary>
        /// Supplies arguments for the message to be sent.
        /// </summary>
        /// <param name="args">
        /// (Optional.) One of more values to be passed as parameters to the message.
        /// <para />
        /// <b>NOTE:</b> The data types, order, and number of parameters, if
        /// supplied, must match the signature of the message's delegate.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        public SendMessage<T, R> Args(params object[] args)
        {
            _args = args;

            return this;
        }

        /// <summary>
        /// Filters the message queue by the unique identifier that the
        /// message's handler was initially mapped under.
        /// </summary>
        /// <param name="messageId">
        /// (Required). Unique identifier (GUID) that the message handler was
        /// originally tagged with.
        /// <para />
        /// The Zero GUID must not be passed for this parameter.
        /// <para />
        /// If the Zero GUID is passed for this parameter, then this method
        /// throws <see cref="T:System.ArgumentException" />.
        /// </param>
        public void ForMessageId(Guid messageId)
        {
            try
            {
                if (messageId.IsZero()) return;
                if (_args == null) return;

                MessageQueue.PostMessage<T>(messageId, _args);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Specifies that the message is to be sent without any input data.
        /// </summary>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <remarks>
        /// This method initializes the internal storage of this class that is
        /// devoted to storing the argument list for the new message to contain
        /// zero elements.
        /// <para />
        /// <b>NOTE:</b> Calling this method is the same as calling the
        /// <see
        ///     cref="M:xyLOGIX.Queues.Messages.SendMessage.Args" />
        /// method without
        /// passing any parameters. Having this method available can make client
        /// code more fluent.
        /// </remarks>
        public SendMessage<T, R> NoArgs()
        {
            _args = Enumerable.Empty<object>()
                              .ToArray();

            return this;
        }
    }
}