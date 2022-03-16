namespace ZimonIsHimUtils.ExtensionMethods
{
    public static class BooleanExtensionMethods
    {
        /// <summary>
        /// Converts the boolean value into its integer presentation,
        /// with <c>true</c> returning 1 and <c>false</c> returning 0.
        /// </summary>
        /// <param name="boolean">The boolean to convert.</param>
        /// <returns>The int32 value of the boolean.</returns>
        public static int ToInt(this bool boolean)
        {
            return boolean ? 1 : 0;
        }

        /// <summary>
        /// Flips the boolean's value. True will turn into false and vice versa.
        /// </summary>
        /// <param name="boolean">The boolean to flip.</param>
        public static void Flip(this ref bool boolean)
        {
            boolean = !boolean;
        }
    }
}