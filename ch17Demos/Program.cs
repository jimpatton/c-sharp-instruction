using ConsoleLibrary;

namespace ch17Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Chap 17 Demos - File I/O");

            string dir = @"c:\C#\Files\";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
                MyConsole.PrintLine("dir created!");

            }
            else {
                MyConsole.PrintLine("directory already exists");
            }

            string path = dir + "names.text";
            if (!File.Exists(path))
            {
                File.Create(path);
                MyConsole.PrintLine("file created");
            }
            else { 
            MyConsole.PrintLine("file already exists.");
            }

            //write names to our file...
            //StreamWriter writer = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write));
            //writer.WriteLine("Adrian");
            //writer.WriteLine("Jim");
            //writer.WriteLine("Nick");
            //writer.WriteLine("Celina");
            //writer.WriteLine("Drew");
            //writer.Close();
            //MyConsole.PrintLine("Names writing done");

            MyConsole.PrintLine("+++++Reading names.txt+++++");
            StreamReader reader = new StreamReader(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));
            List<string> lines = new List<string>();
            while (reader.Peek() != -1)
            {
                string row = reader.ReadLine() ?? "";
                lines.Add(row);
            }
            reader.Close();

            foreach (string line in lines) { 
            MyConsole.PrintLine($"line = {line}");

            }












            MyConsole.PrintLine("\nBye");
        }
    }
}
