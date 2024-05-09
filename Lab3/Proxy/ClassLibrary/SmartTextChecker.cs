using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class SmartTextChecker : ITextReader
    {
        private ITextReader _reader;

        public SmartTextChecker(ITextReader reader)
        {
            _reader = reader;
        }

        public char[][] ReadFile(string path)
        {
            Console.WriteLine($"Opening file: {path}");
            char[][] content = _reader.ReadFile(path);
            Console.WriteLine($"Successfully read file: {path}");
            int lineCount = content.Length;
            int charCount = 0;
            foreach (char[] line in content)
            {
                charCount += line.Length;
            }
            Console.WriteLine($"Total lines: {lineCount}, Total characters: {charCount}");
            Console.WriteLine($"Closing file: {path}");
            return content;
        }
    }
}
