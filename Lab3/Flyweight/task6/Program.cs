using ClassLibrary;

public class Program
{
    public static void Main()
    {
        string basePath = AppDomain.CurrentDomain.BaseDirectory;
        string resolvedPath = Path.Combine(basePath, @"..\..\..\..\task6\", "RomeoAndJuliet.txt");

        List<LightElementNode> htmlNodes = new List<LightElementNode>();
        CodeHTML nodeCreator = new CodeHTML();
        bool isFirstLine = true;

        using (StreamReader reader = new StreamReader(resolvedPath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                LightElementNode node = nodeCreator.AddHtmlTagsToLine(line, isFirstLine);
                htmlNodes.Add(node);
                isFirstLine = false;
            }
        }

        foreach (LightElementNode node in htmlNodes)
        {
            Console.WriteLine(node.OuterHTML());
        }

        long totalMemory = GC.GetTotalMemory(true);
        Console.WriteLine($"Total memory used: {totalMemory} bytes");
    }
}