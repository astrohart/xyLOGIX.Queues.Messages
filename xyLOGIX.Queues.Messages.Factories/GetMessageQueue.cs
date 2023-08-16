using PostSharp.Patterns.Diagnostics;
using xyLOGIX.Queues.Messages.Interfaces;

namespace xyLOGIX.Queues.Messages.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:xyLOGIX.Queues.Messages.Interfaces.IMessageQueue" /> interface.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetMessageQueue
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:xyLOGIX.Queues.Messages.Interfaces.IMessageQueue" /> interface,
        /// and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:xyLOGIX.Queues.Messages.Interfaces.IMessageQueue" /> interface.
        /// </returns>
        public static IMessageQueue SoleInstance()
            => MessageQueue.Instance;
    }
}