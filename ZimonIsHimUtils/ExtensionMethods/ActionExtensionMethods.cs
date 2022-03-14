using System;
using System.Globalization;

namespace ZimonIsHimUtils.ExtensionMethods
{
    public static class ActionExtensionMethods
    {
        public static void DoFor(this Action action, IConvertible amount)
        {
            for (var i = 0; i < amount.ToInt32(CultureInfo.DefaultThreadCurrentCulture); i++)
            {
                action();
            }
        }

        public static void DoFor<T>(this Action<T> action, T parameter, IConvertible amount)
        {
            for (var i = 0; i < amount.ToInt32(CultureInfo.DefaultThreadCurrentCulture); i++)
            {
                action(parameter);
            }
        }
    }
}
