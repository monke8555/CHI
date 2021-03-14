using CHI;
using System;
using System.Drawing;
//using System.Windows.Forms;

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
            string SupportedTypes = "PNG, JP(E)G, TIF(F), GIF, and BMP";
            foreach (var arg in args) {
                switch (arg) {
                    case "--help":
                    case "-h":
                        // Prints the list of arguments
                        string s = "CHI (Compressed Hex Images) version " + v;
                        Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                        Console.WriteLine(s);
                        Console.SetCursorPosition(0, Console.CursorTop);
                        Console.WriteLine("Argument syntax:\n--some-flag\n-sf (Short for some-flag)\n--number=123\n-n=123 (Short for number)\nNOTE: All arguments and values are case-insensitive\n");
                        Console.WriteLine("Arguments:");
                        Console.WriteLine($"--help or -h: Shows this list\n");
                        Console.WriteLine($"--version or -v: Shows the version\n");
                        Console.WriteLine($"--from={{type}} or -f={{type}}: The image type to convert from. Supported types: {SupportedTypes}\n");
                        Console.WriteLine($"NOTE: If the type to convert to is not CHI, then this must be CHI. And if the type to convert to is CHI, then this must be any other type\n");
                        Console.WriteLine($"--to={{type}} or -t={{type}}: The image type to convert to. Supported types: {SupportedTypes}\n");
                        Console.WriteLine($"NOTE: If the type to convert from is not CHI, then this must be CHI. And if the type to convert from is CHI, then this must be any other type\n");
                        Console.WriteLine("--show or -s: Flag to show the image given a path\n");
                        Console.WriteLine($"--path={{path}} or -p={{path}}: The path of the file to convert.");
                        break;
                    case "--version":
                    case "-v":
						//using (OpenFileDialog dlg = new OpenFileDialog()) {
						//	dlg.Title = "Open Image";
						//	dlg.Filter = "bmp files (*.bmp)|*.bmp";
						//	if (dlg.ShowDialog() == DialogResult.OK) {
						//		PictureBox PictureBox1 = new PictureBox();

						//		// Create a new Bitmap object from the picture file on disk,
						//		// and assign that to the PictureBox.Image property
						//		PictureBox1.Image = new Bitmap(dlg.FileName);
						//		Form Form1 = new Form();
						//		Form1.Controls.Add(PictureBox1);
						//	}
						//}
						Console.WriteLine("CHI (Compressed Hex Images) version " + v);
                        break;
                }
            }

            return 0;
        }
    }
}