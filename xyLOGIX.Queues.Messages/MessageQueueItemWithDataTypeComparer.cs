using System.Collections.Generic;
using xyLOGIX.Queues.Messages.Interfaces;

namespace xyLOGIX.Queues.Messages
{
    /// <summary>
    /// Compares two instances of objects that implement the
    /// <see
    ///     cref="T:xyLOGIX.Queues.Messages.Interfaces.IMessageQueueItem" />
    /// interface to see if they are equal.
    /// </summary>
    public class
        MessageQueueItemWithDataTypeComparer : IEqualityComparer<
            IMessageQueueItem>
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static MessageQueueItemWithDataTypeComparer() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected MessageQueueItemWithDataTypeComparer() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see
        ///     cref="T:xyLOGIX.Queues.Messages.MessageQueueItemWithNoDataTypeComparer" />
        /// .
        /// </summary>
        public static MessageQueueItemWithDataTypeComparer Instance { get; } =
            new MessageQueueItemWithDataTypeComparer();

        /// <summary>
        /// Determines whether the specified objects are equal.
        /// </summary>
        /// <param name="x">
        /// The first object that implements the <see cref="T:typeparamref" />
        /// interface to compare.
        /// </param>
        /// <param name="y">
        /// The second object that implements the <see cref="T:typeparamref" />
        /// interface to compare.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified objects are equal;
        /// otherwise, <see langword="false" />.
        /// </returns>
        public bool Equals(IMessageQueueItem x, IMessageQueueItem y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (x is null) return false;
            if (y is null) return false;
            if (x.GetType() != y.GetType()) return false;
            return x.EventDataType == y.EventDataType &&
                   Equals(x.MessageHandler, y.MessageHandler) &&
                   x.MessageId.Equals(y.MessageId);
        }

        /// <summary>
        /// Returns a hash code for the specified object.
        /// </summary>
        /// <param name="obj">
        /// The <see cref="T:System.Object" /> for which a hash code is to be returned.
        /// </param>
        /// <returns>
        /// A hash code for the specified object.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// The type of <paramref name="obj" /> is a reference type and
        /// <paramref
        ///     name="obj" />
        /// is <see langword="null" />.
        /// </exception>
        public int GetHashCode(IMessageQueueItem obj)
        {
            unchecked
            {
                var hashCode = obj.EventDataType != null
                    ? obj.EventDataType.GetHashCode()
                    : 0;
                hashCode = (hashCode * 397) ^ (obj.MessageHandler != null
                    ? obj.MessageHandler.GetHashCode()
                    : 0);
                hashCode = (hashCode * 397) ^ obj.MessageId.GetHashCode();
                return hashCode;
            }
        }
    }
}