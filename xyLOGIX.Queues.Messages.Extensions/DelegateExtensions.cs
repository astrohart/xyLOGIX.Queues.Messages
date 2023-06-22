using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Queues.Messages.Factories;
using xyLOGIX.Queues.Messages.Interfaces;

namespace xyLOGIX.Queues.Messages.Extensions
{
    /// <summary>
    /// Provides extension methods that are designed to make assigning messages
    /// to handlers more fluent.
    /// </summary>
    public static class DelegateExtensions
    {
        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.Queues.Messages.Interfaces.IMessageQueue" /> interface.
        /// </summary>
        private static IMessageQueue MessageQueue { get; } =
            GetMessageQueue.SoleInstance();

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
        public static void MapToMessage<T>(this Delegate d)
        {
            try
            {
                if (d == null) return;

                MessageQueue.MapMessage<T>(d);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
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
        /// passed a <see langword="null" /> value.
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
            try
            {
                if (d == null) return;
                if (Guid.Empty == messageId) return;

                MessageQueue.MapMessage<T>(messageId, d);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
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
        /// passed a <see langword="null" /> value.
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
            try
            {
                if (d == null) return;
                if (Guid.Empty == messageId) return;

                MessageQueue.MapMessage(messageId, d);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}