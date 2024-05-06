using ClassLibrary;

class Program
{
    static void Main()
    {
        Authenticator auth1 = Authenticator.GetInstance();
        Authenticator auth2 = Authenticator.GetInstance();

        if (auth1 == auth2)
        {
            Console.WriteLine("Singleton works, both variables contain the same instance");
        }
        else
        {
            Console.WriteLine("Singleton failed, variables contain different instances");
        }

        auth1.Authenticate();
    }
}
