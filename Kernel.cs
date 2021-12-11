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
                Console.WriteLine("NC-DOS 1.0.0 (C) 2021 EnZon3 (Made with Cosmos (This isn't a watermark I just put this here.))");

            }


            if (input == "helloworld")
            {
                clearScreen();
                Console.WriteLine("Hello world!");

            }

            if (input == "help")
            {
                Console.WriteLine("about: Self-explainatory tbh");
                Console.WriteLine("helloworld: Also self-explainatory");
               // Console.WriteLine("restart: VERY self explainatory");

            }
    }
}
