using System;
using System.Collections.Generic;

namespace ZimonIsHimUtils.ExtensionMethods
{
    public static class EnumerableExtensionMethods
    {
        /// <summary>
        /// Iterates over a <c>IEnumerable</c> and passes each item to a given action as the parameter.
        /// </summary>
        /// <typeparam name="T">The type of the items and the parameter of the action.</typeparam>
        /// <param name="items">The items to iterate over and perform an action on per item.</param>
        /// <param name="action">The action to perform per item.</param>
        public static void Each<T>(this IEnumerable<T> items, Action<T> action)
        {
            foreach (var item in items) action(item);
        }
    }
}