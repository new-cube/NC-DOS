using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Simple fatal error screen
/// </summary>
namespace bugcheck {
	public class BugChk
	{
		public static void BgChk(string e, string info)
		{
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.Clear();
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("								   NC-DOS");
			Console.WriteLine("		  A fatal error has occured. Please restart your computer.");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("ERR: " + e);
			Console.WriteLine("INFO: " + info);
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			//return 0;
		}
	}
}
