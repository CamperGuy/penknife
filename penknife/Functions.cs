using System;
using System.Text;

namespace penknife
{
    public class Functions
    {
        enum Base
        {
            base2,
            base10,
            base16
        }

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

        public static string ConvertBase(string number, string format)
        {
            Base startBase;
            Base endBase;
            bool defaultStart10 = false;

            if (number.StartsWith("0b") || number.StartsWith("bin"))
                startBase = Base.base2;
            else if (number.StartsWith("0d") || number.StartsWith("dec"))
                startBase = Base.base10;
            else if (number.StartsWith("0x") || number.StartsWith("hex"))
                startBase = Base.base16;
            else
            {
                defaultStart10 = true;
                startBase = Base.base10;
            }

            if (format.StartsWith("0b") || format.StartsWith("bin") || format.StartsWith("02"))
                endBase = Base.base2;
            else if (format.StartsWith("0d") || format.StartsWith("dec") || format.StartsWith("10"))
                endBase = Base.base10;
            else if (number.StartsWith("0x") || format.StartsWith("hex") || format.StartsWith("16"))
                endBase = Base.base16;
            else
                endBase = Base.base10;

            if (!defaultStart10)
                number = number.Remove(0, 2);

            try
            {
                if (startBase.Equals(Base.base2) && endBase.Equals(Base.base10))
                {
                    Console.WriteLine("Binary: " + number);
                    return "Decimal: " + Convert.ToInt32(number, 2).ToString("D");
                }
                else if (startBase.Equals(Base.base2) && endBase.Equals(Base.base16))
                {
                    Console.WriteLine("Binary: " + number);
                    return "Hex: " + Convert.ToInt32(number, 2).ToString("X");
                }
                else if (startBase.Equals(Base.base10) && endBase.Equals(Base.base2))
                {
                    Console.WriteLine("Decimal: " + number);
                    return "Binary: " + Convert.ToString(Convert.ToInt32(number, 10), 2);
                }
                else if (startBase.Equals(Base.base10) && endBase.Equals(Base.base16))
                {
                    Console.WriteLine("Decimal: " + number);
                    return "Hex: " + Convert.ToInt32(number, 10).ToString("X");
                }
                else if (startBase.Equals(Base.base16) && endBase.Equals(Base.base2))
                {
                    Console.WriteLine("Hex: " + number);
                    return "Binary: " + Convert.ToString(Convert.ToInt32(number, 16), 2);
                }
                else if (startBase.Equals(Base.base16) && endBase.Equals(Base.base10))
                {
                    Console.WriteLine("Hex: " + number);
                    return "Decimal: " + Convert.ToInt32(number, 16).ToString("D");
                }
                else
                {
                    return "Trying to convert number into the same format.";
                }
            }
            catch(System.FormatException)
            {
                return "Invalid format given. Please double-check your inputs";
            }
        }

        public static string Caps(string lowercase) { return lowercase.ToUpper(); }

        public static string Lower(string uppercase) { return uppercase.ToLower(); }

        public static string CharBytes(string characters, byte[] bytearray)
        {
            string bytecodes = "";

            if (bytearray.Length == 1)
            {
                Console.Write(" " + characters);
                bytecodes += bytearray[0];
            }
            else
            {
                for (int i = 0; i < characters.ToCharArray().Length; i++)
                {
                    if (i == 0)
                    {
                        Console.Write(" " + characters.ToCharArray()[i] + " | ");
                        if (bytearray[0].ToString().Length == 1)
                            bytecodes += " " + bytearray[i].ToString() + " | ";
                        else if (bytearray[0].ToString().Length == 2)
                            bytecodes += bytearray[i].ToString() + " | ";
                        else
                            bytecodes += bytearray[i].ToString() + "| ";
                    }
                    else
                    {
                        if (bytearray[i].ToString().Length == 1)
                            bytecodes += "  | " + bytearray[i].ToString() + " |  ";
                        else if (bytearray[i].ToString().Length == 2)
                            bytecodes += "  |" + bytearray[i].ToString() + " |  ";
                        else
                            bytecodes += "  |" + bytearray[i].ToString() + "|  ";

                        Console.Write("  | " + characters.ToCharArray()[i] + " |  ");
                    }
                }
            }

            Console.Write("\n");
            return bytecodes;
        }

        public static string Replace(string word, string pattern, string replacement)
        {
            return word.Replace(pattern, replacement);
        }
    }
}
