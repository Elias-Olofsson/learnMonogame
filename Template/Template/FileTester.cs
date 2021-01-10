using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public class FileTester
    {
        public string filepath = @"c:\temp\testfile.txt";

        public void WriteFile()
        {
            File.WriteAllText(filepath, "Du har startat spelet men har inte gått igenom enumtestet.");
        }

        public string ReadFile()
        {
            string filecontents = File.ReadAllText(filepath);
            return filecontents;
        }
    }
}
