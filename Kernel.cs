using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace NC_DOS
{
    public class Kernel : Sys.Kernel
    {
        void clearScreen()
        {
            for(var i = 0; i <= 22; i++)
            {
                Console.WriteLine(" "); // Clears screen
            }
        }

        protected override void BeforeRun()
        {
            clearScreen();
            Console.WriteLine("NC-DOS 1.0.0");
            clearScreen();
        }

        protected override void Run()
        {
            var input = Console.ReadLine();
            if (input == "about")
            {
                Console.WriteLine("NC-DOS 1.0.0 (C) 2021 EnZon3");

            }
            
            string textEditor()
            {
                bool inTextEditor = true;
                int x = 1;
                string[] textToSave = {"/",};
                string savedText = "No text";
                while (inTextEditor == true)
                {
                    textToSave[x] = input;
                    x++;
                    if (input == "t-exit")
                    {
                        inTextEditor = false;
                    }
                }
                savedText = string.Join("", textToSave);
                return savedText;
            }

            if (input == "helloworld")
            {
                clearScreen();
                Console.WriteLine("Hello World!");

            }

            if (input == "help")
            {
                Console.WriteLine("about: Self-explainatory tbh");
                Console.WriteLine("helloworld: Also self-explainatory");
                Console.WriteLine("charset: Displays every typeable charater (except the ones that can't go in quotation marks.)");

            }
            if (input == "charset")
            {
                Console.WriteLine("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()~`-_=+[{]}|:;',<.>?/");
                Console.WriteLine("The quick brown fox jumps over the lazy dog");

            }
            if (input == "manager")
            {
                bool exit = false;
                Console.WriteLine("+-------------------------------------------------------------------------+");
                Console.WriteLine("|   Program Manager  v1.0                                                 |");
                Console.WriteLine("--------------------------------------------------------------------------|");
                Console.WriteLine("|  How does this work?                                                    |");
                Console.WriteLine("|  	Well, The data for each built in program is saved to memory and      |");
                Console.WriteLine("|  when you do the command: --resume [program] , the program you were usi |");
                Console.WriteLine("|  ng gets saved and the other program gets loaded again.                 |");
                Console.WriteLine("|  Programs:                                                              |");
                Console.WriteLine("|    textedit, tempfile, guessgame                                        |");
                Console.WriteLine("|  How to open program: --open [program name]                             |");
                Console.WriteLine("+-------------------------------------------------------------------------+");
                
                while (exit = false)
                {
                    string[] ProccessedInput = input.ToLower().Split(' ');

                    if (ProccessedInput[0] == "--open")
                    {
                        if (ProccessedInput[1] == "textedit")
                        {
                            string text = textEditor();
                        }
                    }
                    if (ProccessedInput[0] == "--exit")
                        {
                            exit = true;
                        }
                }

            }
        }
    }
}
