using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace NC_DOS
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.WriteLine("NC-DOS 1.0.0");
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
                Console.WriteLine("Hello world!");

            }

            if (input == "help")
            {
                Console.WriteLine("about: Self-explainatory tbh");
                Console.WriteLine("helloworld: Also self-explainatory");

            }
        }
    }
}
