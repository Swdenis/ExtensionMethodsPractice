using System;
namespace AmazingExtensions
{
    public static class ExtendHuman
    {
        public static bool IsDistressCall(this string s) {
            if (s.Contains("Help!"))
                return true;
            else return false;

                }
    }
}
