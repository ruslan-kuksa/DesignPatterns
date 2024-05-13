using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class FileDownload : IStrategy
    {
        public void LoadImage(string path)
        {
            Console.WriteLine($"Download image from file system: {path}");
        }
    }
}
