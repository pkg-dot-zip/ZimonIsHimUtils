using System;
using System.Globalization;

namespace ZimonIsHimUtils.ExtensionMethods
{
    public static class ConvertableExtensionMethods
    {
        public static void DoFor(this IConvertible convertible, Action action)
        {
            for (int i = 0; i < convertible.ToInt32(CultureInfo.DefaultThreadCurrentCulture); i++)
            {
                action();
            }
        }
    }
}