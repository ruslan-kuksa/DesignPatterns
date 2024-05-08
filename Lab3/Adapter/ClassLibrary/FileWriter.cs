using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class FileWriter
    {
        public void Write(string text)
        {
            Console.WriteLine($"Writing to file: {text}");
        }

        public void WriteLine(string text)
        {
            Console.WriteLine($"Writing line to file: {text}");
        }
    }
}
