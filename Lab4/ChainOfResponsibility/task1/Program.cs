using ClassLibrary;

class Program
{
    static void Main()
    {
        FirstSupportHandler FirstSupport = new FirstSupportHandler();
        SecondSupportHandler SecondSupport = new SecondSupportHandler();
        ThirdSupportHandler ThirdSupport = new ThirdSupportHandler();
        FourthSupportHandler FourthSupport = new FourthSupportHandler();

        FirstSupport.SetNext(SecondSupport).SetNext(ThirdSupport).SetNext(FourthSupport);

        string[] validInputs = { "1", "2", "3", "4" };

        while (true)
        {
            Console.WriteLine("Press:\n1 for Fisrt Support" +
                "\n2 for Second Support" +
                "\n3 for Third Support" +
                "\n4 for Fourth Support" +
                "\n0 to Retry:");
            string input = Console.ReadLine();
            string result = FirstSupport.Handle(input);
            Console.WriteLine(result);
            if (validInputs.Contains(input)) break;
        }
    }
}