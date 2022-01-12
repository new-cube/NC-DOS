using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using bugcheck;
using Cosmos.System.FileSystem.VFS;
using Cosmos.System.FileSystem;

namespace NC_DOS
{
    public class Kernel : Sys.Kernel
    {
        CosmosVFS fs = new Sys.FileSystem.CosmosVFS();
        void clearScreen()
        {
            for(var i = 0; i <= 22; i++)
            {
                Console.WriteLine(" "); // Clears screen
            }
        }

        protected override void BeforeRun()
        {
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
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
            
            //BugChk bChk = new BugChk();
            
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
                Console.WriteLine("charset: Every printable character that did not cause an error.");
                Console.WriteLine("crash: Crashes the OS.");

            }
            if (input == "charset")
            {
                Console.WriteLine("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()~`-_=+[{]}|:;',<.>?/");
                Console.WriteLine("The quick brown fox jumps over the lazy dog");

            }
            if (input == "crash")
            {
                try
                {
                    throw new Exception();
                }
                catch (Exception) 
                {
                    Console.WriteLine("crashed");
                    BugChk.BgChk("Exception", "No info");
                }
            }
            if (input == "space")
            {
                long available_space = Sys.FileSystem.VFS.VFSManager.GetAvailableFreeSpace("0:/");
                Console.WriteLine("Available Free Space: " + available_space);
            }
            if (input == "filesystem")
            {
                string fs_type = Sys.FileSystem.VFS.VFSManager.GetFileSystemType("0:/");
                Console.WriteLine("File System Type: " + fs_type);
            }
            if (input == "dir")
            {
                var directory_list = Sys.FileSystem.VFS.VFSManager.GetDirectoryListing("0:/");
                foreach (var directoryEntry in directory_list)
                {
                    Console.WriteLine(directoryEntry.mName);
                }
            }
            if (input == "filecli")
            {
                Console.WriteLine("Opened FileCLI");
                while (true)
                {
                    var fcIn = Console.ReadLine();
                    string[] ProccessedInput2 = fcIn.ToLower().Split(' ');
                    if (ProccessedInput2[0] == "+open")
                    {
                        try
                        {
                            var hello_file = Sys.FileSystem.VFS.VFSManager.GetFile(@ProccessedInput2[1]);
                            var hello_file_stream = hello_file.GetFileStream();

                            if (hello_file_stream.CanRead)
                            {
                                byte[] text_to_read = new byte[hello_file_stream.Length];
                                hello_file_stream.Read(text_to_read, 0, (int)hello_file_stream.Length);
                                Console.WriteLine(Encoding.Default.GetString(text_to_read));
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    }
                    if (ProccessedInput2[0] == "+write")
                    {
                        try
                        {
                            var hello_file = Sys.FileSystem.VFS.VFSManager.GetFile(@ProccessedInput2[1]);
                            var hello_file_stream = hello_file.GetFileStream();

                            if (hello_file_stream.CanWrite)
                            {
                                byte[] text_to_write = Encoding.ASCII.GetBytes(ProccessedInput2[2]);
                                hello_file_stream.Write(text_to_write, 0, text_to_write.Length);
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    }
                    if (ProccessedInput2[0] == "+new")
                    {
                        try
                        {
                            Sys.FileSystem.VFS.VFSManager.CreateFile(@"0:\hello_from_elia.txt");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    }
                    if (ProccessedInput2[0] == "+exit")
                    {
                        break;
                    }
                }
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
                Console.WriteLine("|    textedit, guessgame                                                  |");
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
                               for (int b = 0; b <= lines; b++)
                               {
                                        Console.WriteLine(savedValue[b].ToString());

                               }
                               var input3 = Console.ReadLine();
                               if (input3 == "t-exit")
                               {
                               inEditor = false;
                               Console.WriteLine("While Loop gone!");
                               savedValue[0] = " ";
                               } else
                               {
                                    savedValue[counter] = input3;
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
