using System;
using static BigT.Big;

namespace BigT_Localization_Example
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
#if DEBUG
            //Run parsing from project root
            BigT.Parser.RunParsing("..\\..");
#endif
            //Load translations by using default filename
            LoadTranslations();
            var command = 0;
            while (command != 5)
            {
                PrintOptions();
                var input = Console.In.ReadLine();
                if (!int.TryParse(input, out command))
                    command = 0;
                else
                    ProcessCommand(command);
                Console.Out.WriteLine();
            }
            Console.Out.WriteLine(T("Good bye"));
        }

        private static void PrintOptions()
        {
            Console.Out.WriteLine(T("Select command:"));
            Console.Out.WriteLine(T("1 - Greet"));
            Console.Out.WriteLine(T("2 - Change language to English"));
            Console.Out.WriteLine(T("3 - Change language to Finnish"));
            Console.Out.WriteLine(T("4 - Change language to Swedish"));
            Console.Out.WriteLine(T("5 - Quit"));
        }

        private static void ProcessCommand(int command)
        {
            switch (command)
            {
                case 1:
                    Console.Out.WriteLine(T("Hello!"));
                    return;
                case 2:
                    SetLanguage("Default");
                    return;
                case 3:
                    SetLanguage("Finnish");
                    return;
                case 4:
                    SetLanguage("Swedish");
                    return;
                default:
                    return;
            }
        }
    }
}
