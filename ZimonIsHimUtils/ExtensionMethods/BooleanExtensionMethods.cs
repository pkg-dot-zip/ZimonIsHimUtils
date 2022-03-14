namespace ZimonIsHimUtils.ExtensionMethods
{
    public static class BooleanExtensionMethods
    {
        public static int ToInt(this bool boolean)
        {
            return boolean ? 1 : 0;
        }

        public static void Flip(this ref bool boolean)
        {
            boolean = !boolean;
        }
    }
}