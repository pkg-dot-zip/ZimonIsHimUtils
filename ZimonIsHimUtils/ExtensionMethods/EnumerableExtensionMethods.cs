using System;
using System.Collections.Generic;

namespace ZimonIsHimUtils.ExtensionMethods
{
    public static class EnumerableExtensionMethods
    {
        public static void Each<T>(this IEnumerable<T> items, Action<T> action)
        {
            foreach (var item in items) action(item);
        }
    }
}