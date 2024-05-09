using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class SmartTextReaderLocker : ITextReader
    {
        private ITextReader _reader;
        private Regex _regex;

        public SmartTextReaderLocker(ITextReader reader, string pattern)
        {
            _reader = reader;
            _regex = new Regex(pattern);
        }

        public char[][] ReadFile(string path)
        {
            if (_regex.IsMatch(path))
            {
                Console.WriteLine("Access denied!");
                return new char[0][];
            }
            else
            {
                return _reader.ReadFile(path);
            }
        }
    }
}
