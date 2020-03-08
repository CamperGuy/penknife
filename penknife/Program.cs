using System;

namespace penknife
{
    class Program
    {
        static void Main(string[] arguments)
        {
            string[] args;
            args = new string[3] { "count", "lolololol", "lo"};

            /*
            string arguments = "";
            foreach(string item in args)
            {
                arguments.Insert(arguments.Length - 1, item);
            }
            Console.WriteLine(arguments);
            */
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
