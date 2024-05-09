using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class SmartTextReader : ITextReader
    {
        public char[][] ReadFile(string path)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string resolvedPath = Path.Combine(basePath, @"..\..\..\..\task4\", "test.txt");

            string[] lines = File.ReadAllLines(resolvedPath);
            char[][] result = new char[lines.Length][];
            for (int i = 0; i < lines.Length; i++)
            {
                result[i] = lines[i].ToCharArray();
            }
            return result;
        }
    }
}
