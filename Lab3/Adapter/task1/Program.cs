
using ClassLibrary;

class Program
{
    static void Main()
    {
        Logger Logger = new Logger();
        Logger.Log("This is a log message");
        Logger.Error("This is an error message");
        Logger.Warn("This is a warning message");

        FileAdapter fileLogger = new FileAdapter();
        fileLogger.Log("This is a log message");
        fileLogger.Error("This is an error message");
        fileLogger.Warn("This is a warning message");
    }
}