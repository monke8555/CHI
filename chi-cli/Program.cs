using System;
using CHI;

namespace chicli {
    static class Program {
        static int Main(string[] args) {
            if (args.Length == 0) {
                return DoArgs(new string[1] { "-h" });
            }

            return DoArgs(args);
        }

        static int DoArgs(string[] args) {
            string v = "0.1.0-alpha";
            foreach (var arg in args) {
                switch (arg) {
                    case "--help":
                    case "-h":
                        // Prints the list of arguments
                        string s = "CHI (Compressed Hex Images) version " + v;
                        Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                        Console.WriteLine(s);
                        Console.SetCursorPosition(0, Console.CursorTop);
                        Console.WriteLine("Argument syntax:\n--some-flag\n-sf (Short for some-flag)\n--number=123\n-n=123 (Short for number)\n");
                        Console.WriteLine("Arguments:");
                        Console.WriteLine("--help or --h: Shows this list \n--version or --v: Shows the version");
                        break;
                }
            }

            return 0;
		}
    }
}