using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public sealed class Authenticator
    {
        private Authenticator() { }
        private static Authenticator _instance;
        public static Authenticator GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Authenticator();
            }
            return _instance;
        }
        public void Authenticate()
        {
            Console.WriteLine("Authentication successful");
        }
    }
}
