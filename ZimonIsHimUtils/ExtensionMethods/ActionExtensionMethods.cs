using System;
using System.Globalization;

namespace ZimonIsHimUtils.ExtensionMethods
{
    public static class ActionExtensionMethods
    {
        /// <summary>
        /// Performs an action a given amount of times.
        /// </summary>
        /// <param name="action">The action to perform a given amount of times.</param>
        /// <param name="amount">The amount of times to perform the action.</param>
        public static void DoFor(this Action action, IConvertible amount)
        {
            for (var i = 0; i < amount.ToInt32(CultureInfo.DefaultThreadCurrentCulture); i++)
            {
                action();
            }
        }

        /// <summary>
        /// Performs an action with a parameter T (generics) a given amount of times.
        /// </summary>
        /// <typeparam name="T">The type of the parameter of the action to perform.</typeparam>
        /// <param name="action">The action to perform a given amount of times. Takes a parameter of type T.</param>
        /// <param name="parameter">The parameter to pass to the action.</param>
        /// <param name="amount">The amount of times to perform the action.</param>
        public static void DoFor<T>(this Action<T> action, T parameter, IConvertible amount)
        {
            for (var i = 0; i < amount.ToInt32(CultureInfo.DefaultThreadCurrentCulture); i++)
            {
                action(parameter);
            }
        }
    }
}