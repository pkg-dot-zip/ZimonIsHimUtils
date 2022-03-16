using System;
using System.Globalization;

namespace ZimonIsHimUtils.ExtensionMethods
{
    public static class ConvertibleExtensionMethods
    {
        /// <summary>
        /// Performs a given action a given amount of times.
        /// </summary>
        /// <param name="convertible">The amount of times to perform the action.</param>
        /// <param name="action">The action to perform a given amount of times.</param>
        public static void DoFor(this IConvertible convertible, Action action)
        {
            for (var i = 0; i < convertible.ToInt32(CultureInfo.DefaultThreadCurrentCulture); i++)
            {
                action();
            }
        }

        /// <summary>
        /// Performs a given action a given amount of times.
        /// Will pass the iteration as a parameter to the action.
        /// </summary>
        /// <param name="convertible">The amount of times to perform the action.</param>
        /// <param name="action">The action to perform a given amount of times. Takes in the iteration amount.</param>
        public static void DoFor(this IConvertible convertible, Action<int> action)
        {
            for (var i = 0; i < convertible.ToInt32(CultureInfo.DefaultThreadCurrentCulture); i++)
            {
                action(i);
            }
        }
    }
}