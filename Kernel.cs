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
            
            /*
            string textEditor(string save)
            {
                bool inTextEditor = true;
                string savedText = "/";
               // int x = 1;
               // string[] textToSave = {"/",};
               // string savedText = "No text";
               if (save != "/")
                {
                    Console.WriteLine(save);
                }
                while (inTextEditor == true)
                {
                    /*
                    textToSave[x] = input;
                    x++;
                    
                    if (input == "t-exit")
                    {
                        inTextEditor = false;
                        savedText = input + "/";
                    }
                    return savedText;
                }
                // savedText = string.Join("", textToSave);
                return savedText;
            }  
            */
            if (input == "helloworld")
            {
                clearScreen();
                Console.WriteLine("Hello World!");

            }

            if (input == "help")
            {
                Console.WriteLine("about: Self-explainatory tbh");
                Console.WriteLine("helloworld: Also self-explainatory");

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
                Console.WriteLine("|  	Well, The data for each built in program is saved to memory and   |");
                Console.WriteLine("|  when you do the command: --resume [program] , the program you were usi |");
                Console.WriteLine("|  ng gets saved and the other program gets loaded again.                 |");
                Console.WriteLine("|  Programs:                                                              |");
                Console.WriteLine("|    textedit, tempfile, guessgame                                        |");
                Console.WriteLine("|  How to open program: --open [program name]                             |");
                Console.WriteLine("+-------------------------------------------------------------------------+");
                while (exit == false)
                {
                    var managerInput = Console.ReadLine();
                    string[] ProccessedInput = managerInput.ToLower().Split(' ');
                    string[] savedValue = {"/"};
                    savedValue[0] = "/";
                    int lines = 1;
                   // string text = "/";

                    if (ProccessedInput[0] == "--open")
                    {
                        if (ProccessedInput[1] == "textedit")
                        {
                           // TODO: Multi-Line support
                           // text = textEditor("/");
                           bool inEditor = true;
                           Console.WriteLine("TextEdit v1.0");
                           int counter = 1;
                           while (inEditor == true)
                            {
                                var input2 = Console.ReadLine();
                                if (input2 == "t-exit")
                                {
                                    inEditor = false;
                                    Console.WriteLine("While Loop gone!");
                                    lines = counter;
                                }
                                if (input2 != "t-exit")
                                {
                                    savedValue[counter] = input2;
                                    savedValue[0] = "ok";
                                    counter++;
                                }
                        }
                    }
                    if (ProccessedInput[0] == "--resume")
                    {
                        if (ProccessedInput[1] == "textedit")
                        {
                           // string text2 = textEditor(text);
                           int counter = 1;
                           if (savedValue[0] == "/")
                           {
                                Console.WriteLine("TextEdit is not open!");
                           }
                           if (savedValue[0] == "ok")
                           {
                               // var tempString = savedValue;
                               bool inEditor = true;
                               counter = lines + 1;
                               for (int i = 0; i <= lines; i++)
                               {
                                        Console.WriteLine(savedValue[i].ToString());

                               }
                               var input2 = Console.ReadLine();
                               if (input2 == "t-exit")
                               {
                               inEditor = false;
                               Console.WriteLine("While Loop gone!");
                               savedValue[0] = " ";
                               } else
                               {
                                    savedValue[counter] = input2;
                                    counter++;
                               }
                           }
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
}
