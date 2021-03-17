using System;

namespace xyLOGIX.Queues.Messages
{
    /// <summary>
    /// Provides extension methods that are designed to make assigning messages
    /// to handlers more fluent.
    /// </summary>
    public static class DelegateExtensions
    {
        /// <summary>
        /// Called to map a <see cref="T:System.Delegate" />, that specifies the
        /// code to execute in order to handle a message, with a data parameter
        /// type, <typeparamref name="T" />.
        /// </summary>
        /// <typeparam name="T">
        /// Name of the data type of the object that carries the message's data.
        /// </typeparam>
        /// <param name="d">
        /// (Required.) Reference to the <see cref="T:System.Delegate" /> that is
        /// to be matched with messages that carry objects of the
        /// <typeparamref
        ///     name="T" />
        /// .
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="d" />, is passed a
        /// <c>null</c> value.
        /// </exception>
        public static void MapToMessage<T>(this Delegate d)
        {
            if (d == null) throw new ArgumentNullException(nameof(d));

            MessageQueue.Instance.MapMessage<T>(d);
        }

        /// <summary>
        /// Called to map a <see cref="T:System.Delegate" />, that specifies the
        /// code to execute in order to handle a message, with a data parameter
        /// type, <typeparamref name="T" />.
        /// </summary>
        /// <typeparam name="T">
        /// Name of the data type of the object that carries the message's data.
        /// </typeparam>
        /// <param name="d">
        /// (Required.) Reference to the <see cref="T:System.Delegate" /> that is
        /// to be matched with messages that carry objects of the
        /// <typeparamref
        ///     name="T" />
        /// .
        /// </param>
        /// <param name="messageId">
        /// (Required.) Unique identifier (GUID) to be associated with the
        /// message to allow subscribers to filter.
        /// <para />
        /// The Zero GUID may not be passed for this parameter. If it is, then
        /// this method throws <see cref="T:System.ArgumentException" />.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="messageId" />, is
        /// passed a <c>null</c> value.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the Zero GUID is supplied for the
        /// <paramref
        ///     name="messageId" />
        /// parameter.
        /// <para />
        /// The Zero GUID is defined as a GUID that has all its values set to zero.
        /// </exception>
        public static void MapToMessage<T>(this Delegate d, Guid messageId)
        {
            if (d == null) throw new ArgumentNullException(nameof(d));
            if (Guid.Empty == messageId)
                throw new ArgumentException(
                    "You may not pass the Zero GUID for the messageId parameter.",
                    nameof(messageId)
                );

            MessageQueue.Instance.MapMessage<T>(messageId, d);
        }

        /// <summary>
        /// Called to map a <see cref="T:System.Delegate" />, that specifies the
        /// code to execute in order to handle a message, with a unique
        /// identifier, <paramref name="messageId" />.
        /// </summary>
        /// <param name="d">
        /// (Required.) Reference to the <see cref="T:System.Delegate" /> that is
        /// to be matched with messages that have ID of <paramref name="messageId" />.
        /// </param>
        /// <param name="messageId">
        /// (Required.) Unique identifier (GUID) to be associated with the
        /// message to allow subscribers to filter.
        /// <para />
        /// The Zero GUID may not be passed for this parameter. If it is, then
        /// this method throws <see cref="T:System.ArgumentException" />.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="messageId" />, is
        /// passed a <c>null</c> value.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the Zero GUID is supplied for the
        /// <paramref
        ///     name="messageId" />
        /// parameter.
        /// <para />
        /// The Zero GUID is defined as a GUID that has all its values set to zero.
        /// </exception>
        public static void MapToMessage(this Delegate d, Guid messageId)
        {
            if (d == null) throw new ArgumentNullException(nameof(d));
            if (Guid.Empty == messageId)
                throw new ArgumentException(
                    "You may not pass the Zero GUID for the messageId parameter.",
                    nameof(messageId)
                );

            MessageQueue.Instance.MapMessage(messageId, d);
        }
    }
}