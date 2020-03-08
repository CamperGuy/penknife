using System;

namespace penknife
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                // Display the menu with different options and stuff
            }

            if ((args[0].Equals("length") || args[0].Equals("size")) && args.Length == 2)
                Console.Write("\n> " + Functions.Length(args[1]));

            else if (args[0].Equals("reverse"))
            {
                if (args[1].Equals(null))
                    Console.WriteLine("Reverse requires a string, use. use penknife -reverse string");
                else
                    Console.Write("\n> " + Functions.Reverse(args[1]));
            }
                

        }
    }
}
