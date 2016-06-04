using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBJGroupAdder
{
    class Program
    {

        static void Main(string[] args)
        {

            if (args.Length > 0 && File.Exists(args[0]))
            {
                string path = args[0];
                var logFile = File.ReadAllLines(path);
                List<string> lines = new List<string>(logFile);
                for (int i = 0; i < lines.Count; i++)
                {
                    if (lines[i].Contains("usemtl "))
                    {
                        lines.Insert(i + 1, "g mesh" + i);
                    }
                }
                File.WriteAllLines(path, lines);
            }
            }
    }
}
