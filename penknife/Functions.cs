using System;
namespace penknife
{
    public class Functions
    {
        public Functions()
        {
            
        }

        public static int Length(string word)
        {
            return word.Length;
        }

        public static string Reverse(string word)
        {
            char[] CharArray = word.ToCharArray();
            Array.Reverse(CharArray);
            return new string(CharArray);
        }

        public static int Count(string word, char[] characters)
        {
            int amount = 0;
            char[] chararray = word.ToCharArray();

            if (characters.Length == 1)
            {
                foreach (char c in chararray)
                    if (c.Equals(characters[0]))
                        amount++;
            }
            else
            {
                for (int i = 0; i < chararray.Length-1; i++)
                {
                    string sub = word.Substring(i, characters.Length);
                    string test = new string(characters);
                    if (sub.Equals(new string(characters)))
                        amount++;
                }
            }
            return amount;
        }
    }
}
