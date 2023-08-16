using PostSharp.Patterns.Diagnostics;
using System.Collections.Generic;
using xyLOGIX.Queues.Messages.Items.Interfaces;

namespace xyLOGIX.Queues.Messages.Comparers
{
    /// <summary>
    /// Compares two instances of objects that implement the
    /// <see
    ///     cref="T:xyLOGIX.Queues.Messages.Interfaces.IMessageQueueItem" />
    /// interface to see if they are equal. Ignores the event data type
    /// associated with the item.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class
        MessageQueueItemWithNoDataTypeComparer : IEqualityComparer<IMessageQueueItem>
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static MessageQueueItemWithNoDataTypeComparer() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected MessageQueueItemWithNoDataTypeComparer() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see
        ///     cref="T:xyLOGIX.Queues.Messages.Comparers.MessageQueueItemWithNoDataTypeComparer" />
        /// .
        /// </summary>
        public static MessageQueueItemWithNoDataTypeComparer Instance { get; } =
            new MessageQueueItemWithNoDataTypeComparer();

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
            return Equals(x.MessageHandler, y.MessageHandler) &&
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
                var hashCode = obj.MessageHandler != null
                    ? obj.MessageHandler.GetHashCode()
                    : 0;
                hashCode = (hashCode * 397) ^ obj.MessageId.GetHashCode();
                return hashCode;
            }
        }
    }
}