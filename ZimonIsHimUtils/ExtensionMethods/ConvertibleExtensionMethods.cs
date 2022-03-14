using System;
using System.Globalization;

namespace ZimonIsHimUtils.ExtensionMethods
{
    public static class ConvertibleExtensionMethods
    {
        public static void DoFor(this IConvertible convertible, Action action)
        {
            for (var i = 0; i < convertible.ToInt32(CultureInfo.DefaultThreadCurrentCulture); i++)
            {
                action();
            }
        }

        public static void DoFor(this IConvertible convertible, Action<int> action)
        {
            for (var i = 0; i < convertible.ToInt32(CultureInfo.DefaultThreadCurrentCulture); i++)
            {
                action(i);
            }
        }
    }
}