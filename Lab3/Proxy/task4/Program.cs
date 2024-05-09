using ClassLibrary;
using static System.Net.Mime.MediaTypeNames;

public class Program
{
    public static void Main()
    {

        ITextReader reader = new SmartTextReader();
        ITextReader checker = new SmartTextChecker(reader);
        ITextReader locker = new SmartTextReaderLocker(reader, @"\.txt$");

        checker.ReadFile("test.txt");

        locker.ReadFile("test.txt");
        locker.ReadFile("test.pdf");
    }
}