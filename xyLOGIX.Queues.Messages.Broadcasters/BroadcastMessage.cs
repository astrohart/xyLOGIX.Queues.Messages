using PostSharp.Patterns.Diagnostics;
using xyLOGIX.Queues.Messages.Factories;
using xyLOGIX.Queues.Messages.Interfaces;

namespace xyLOGIX.Queues.Messages.Broadcasters
{
    /// <summary>
    /// Broadcasts messages, with event data of type <typeparamref name="T" />,
    /// to all interested parties throughout the application.
    /// </summary>
    /// <typeparam name="T">
    /// Name of the data type of the <c>class</c> or <c>struct</c> that carries
    /// the event data.
    /// </typeparam>
    /// <remarks>
    /// This class is implemented as a singleton.
    /// <para />
    /// This class was designed to be very fluent, in that clients of this class
    /// use the dot operator to string together its methods and properties to
    /// form complete sentences.
    /// <para />
    /// Use this class when you want to invoke all message handlers that say
    /// they work with message data having type <typeparamref name="T" />, and
    /// that do not respond to messages tagged with a unique identifier.
    /// </remarks>
    [Log(AttributeExclude = true)]
    public class BroadcastMessage<T>
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static BroadcastMessage() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected BroadcastMessage() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:SampleMVP.BroadcastMessage" />.
        /// </summary>
        public static BroadcastMessage<T> Having { get; } =
            new BroadcastMessage<T>();

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.Queues.Messages.Interfaces.IMessageQueue" /> interface.
        /// </summary>
        private static IMessageQueue MessageQueue { get; } =
            GetMessageQueue.SoleInstance();

        /// <summary>
        /// Passes a message to the message queue to be sent to all subscribed
        /// parties throughout the application, with the <paramref name="args" /> provided.
        /// </summary>
        /// <param name="args">
        /// (Optional.) One of more values to be passed as parameters to the message.
        /// <para />
        /// <b>NOTE:</b> The data types, order, and number of parameters, if
        /// supplied, must match the signature of the message's delegate.
        /// </param>
        public void Args(params object[] args)
            => MessageQueue.BroadcastMessage<T>(args);
    }
}