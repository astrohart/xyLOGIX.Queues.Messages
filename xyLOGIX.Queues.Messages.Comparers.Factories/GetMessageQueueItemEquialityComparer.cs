using PostSharp.Patterns.Diagnostics;
using System.Collections.Generic;
using xyLOGIX.Queues.Messages.Items.Interfaces;

namespace xyLOGIX.Queues.Messages.Comparers.Factories
{
    /// <summary>
    /// Gets references to instances of objects that implement the
    /// <see cref="T:System.Collections.Generic.IEqualityComparer" /> interface for
    /// pairs of objects that implement the
    /// <see cref="T:xyLOGIX.Queues.Messages.Interfaces.IMessageQueueItem" />
    /// interface.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class GetMessageQueueItemEquialityComparer
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this
        /// class.
        /// </summary>
        static GetMessageQueueItemEquialityComparer() { }

        /// <summary>
        /// Empty, <see langword="private" /> constructor to prohibit direct allocation of this
        /// class.
        /// </summary>
        [Log(AttributeExclude = true)]
        private GetMessageQueueItemEquialityComparer() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see
        ///     cref="T:xyLOGIX.Queues.Messages.Comparers.Factories.GetMessageQueueItemEquialityComparer" />
        /// .
        /// </summary>
        public static GetMessageQueueItemEquialityComparer That { get; } =
            new GetMessageQueueItemEquialityComparer();

        /// <summary>
        /// Gets a reference to the equality comparer that does not take the
        /// event data type into account.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:System.Collections.Generic.IEqualityComparer" /> interface for
        /// objects implementing the
        /// <see cref="T:xyLOGIX.Queues.Messages.Interfaces.IMessageQueueItem" />
        /// interface.
        /// </returns>
        public IEqualityComparer<IMessageQueueItem>
            DoesNotTakeEventDataTypeIntoAccount()
            => MessageQueueItemWithNoDataTypeComparer.Instance;

        /// <summary>
        /// Gets a reference to the equality comparer that takes the event data
        /// type into account.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:System.Collections.Generic.IEqualityComparer" /> interface for
        /// objects implementing the
        /// <see cref="T:xyLOGIX.Queues.Messages.Interfaces.IMessageQueueItem" />
        /// interface.
        /// </returns>
        public IEqualityComparer<IMessageQueueItem>
            TakesEventDataTypeIntoAccount()
            => MessageQueueItemWithDataTypeComparer.Instance;
    }
}