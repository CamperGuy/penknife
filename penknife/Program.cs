using System;

namespace penknife
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("empty arguments");
            }
            else
            {
                if (args.Length == 2)
                {
                    switch (args[0])
                    {
                        case "length":
                            Console.WriteLine("> " + Functions.Length(args[1]));
                            break;
                        case "reverse":
                            Console.WriteLine("> " + Functions.Reverse(args[1]));
                            break;
                    }
                }

                else if (args.Length == 3)
                {
                    switch(args[0])
                    {
                        case "count":
                            Console.WriteLine("> " + Functions.Count(args[1], args[2].ToCharArray()));
                            break;
                    }
                }
            }
        }
    }
}
