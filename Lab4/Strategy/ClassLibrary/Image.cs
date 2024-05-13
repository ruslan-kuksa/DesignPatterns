using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Image
    {
        private IStrategy _strategy;

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Load(string href)
        {
            if (href.StartsWith("http://") || href.StartsWith("https://"))
            {
                SetStrategy(new NetworkDownload());
            }
            else
            {
                SetStrategy(new FileDownload());
            }

            _strategy.LoadImage(href);
        }
    }
}
