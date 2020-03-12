using System;
using System.Text;
using System.Runtime.InteropServices;

namespace penknife
{
    public static class OperatingSystem
    {
        public static bool IsWindows() =>
            RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

        public static bool IsMacOS() =>
            RuntimeInformation.IsOSPlatform(OSPlatform.OSX);

        public static bool IsLinux() =>
            RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
    }

    class Program
    {
        static void Main(string[] args)
        {
            switch(args.Length)
            {
                case 0:
                    Console.WriteLine("empty arguments");
                    break;
                case 1:
                    switch(args[0])
                    {
                        case "help":
                            HelpDisplay();
                            break;
                        case "h":
                            HelpDisplay();
                            break;
                        case "iplocal":
                            Console.WriteLine("> " + Functions.GetLocalIP());
                            break;
                        case "localip":
                            Console.WriteLine("> " + Functions.GetLocalIP());
                            break;
                        case "ippublic":
                            Console.WriteLine("> " + Functions.GetPublicIP());
                            break;
                        case "publicip":
                            Console.WriteLine("> " + Functions.GetPublicIP());
                            break;
                        default:
                            Console.WriteLine("Unrecognised parameter, please use -h for a list of methods");
                            break;
                    }
                    break;
                case 2:
                    switch (args[0].ToLower())
                    {
                        case "length":
                            Console.WriteLine("> " + Functions.Length(args[1]));
                            break;
                        case "reverse":
                            Console.WriteLine("> " + Functions.Reverse(args[1]));
                            break;
                        case "caps":
                            Console.WriteLine("> " + Functions.Caps(args[1]));
                            break;
                        case "lower":
                            Console.WriteLine("> " + Functions.Lower(args[1]));
                            break;
                        case "convert":
                            Console.WriteLine(Functions.ConvertBase(args[1], "dec"));
                            break;
                        case "ascii":
                            Console.WriteLine(Functions.CharBytes(args[1], Encoding.ASCII.GetBytes(args[1].ToString())));
                            break;
                        case "utf":
                            Console.WriteLine(Functions.CharBytes(args[1], Encoding.UTF8.GetBytes(args[1].ToString())));
                            break;
                        default:
                            Console.WriteLine("Unrecognised parameter, please use -h for a list of methods");
                            break;
                    }
                    break;
                case 3:
                    switch (args[0])
                    {
                        case "count":
                            Console.WriteLine("> " + Functions.Count(args[1], args[2].ToCharArray()));
                            break;
                        case "convert":
                            Console.WriteLine(Functions.ConvertBase(args[1], args[2]));
                            break;
                        case "replace":
                            Console.WriteLine("> " + Functions.Replace(args[1], args[2], ""));
                            break;
                        default:
                            Console.WriteLine("Unrecognised parameter, please use -h for a list of methods");
                            break;
                    }
                    break;
                case 4:
                    switch(args[0])
                    {
                        case "replace":
                            Console.WriteLine("> " + Functions.Replace(args[1], args[2], args[3]));
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Internal Error. Program Line 60");
                    break;
            }
        }

        static void HelpDisplay()
        {
            Console.WriteLine("help  |  h");
            Console.WriteLine("      This Menu\n");

            Console.WriteLine("---- String Commands ----");
            Console.WriteLine("length [string]");
            Console.WriteLine("      Returns the length of a string. To count something longer than a\n      word, concatinate the text in quotation marks\n");

            Console.WriteLine("reverse [string]");
            Console.WriteLine("      Reverses a sequence of characters\n");

            Console.WriteLine("count [string] [sequence]");
            Console.WriteLine("      Counts the amount of occurances in the string \n      To count something in longer than a word, concatinate the text  \n      in quotation marks\n");

            Console.WriteLine("ascii [string]");
            Console.WriteLine("      Converts each character into its ASCII code\n");

            Console.WriteLine("utf [string]");
            Console.WriteLine("      Converts each character into its UTF-8 code\n");

            Console.WriteLine("replace [string] [pattern] [replacement]");
            Console.WriteLine("      Replaces a sequence of characters with another");
            Console.WriteLine("      sequence in a given string\n\n");

            Console.WriteLine("---- Finding information ----");
            Console.WriteLine("privateip | ipprivate");
            Console.WriteLine("      Returns the IPv4 Address used to address \n      your machine in the local network\n");
            Console.WriteLine("publicip | ippublic");
            Console.WriteLine("      Returns the IPv4 Address used to address \n      your host on the wider Internet\n\n");


            Console.WriteLine("---- Low-level commands ----");
            Console.WriteLine("convert [number] [base]");
            Console.WriteLine("      Converts a number from one base into another.");
            Console.WriteLine("         To define the starting base use:");
            Console.WriteLine("            Binary:      0b / bin");
            Console.WriteLine("            Decimal:     0d / dec / [empty]");
            Console.WriteLine("            Hexadecimal: 0x / hex");
            Console.WriteLine("         To define the convert-to base use:");
            Console.WriteLine("            Binary:      0b / bin / 02");
            Console.WriteLine("            Decimal:     0d / dec / 10 / [empty]");
            Console.WriteLine("            Hexadecimal: 0x / hex / 16\n");

        }
    }
}
