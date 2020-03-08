using System;
namespace penknife
{
    public class Functions
    {
        public Functions()
        {
            
        }

        public static int Length(String word)
        {
            return word.Length;
        }

        public static string Reverse(String word)
        {
            char[] CharArray = word.ToCharArray();
            Array.Reverse(CharArray);
            return CharArray.ToString();
        }
    }
}
