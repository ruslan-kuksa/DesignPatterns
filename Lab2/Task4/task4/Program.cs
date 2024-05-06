using task4;

class Program
{
    static void Main()
    {
        Virus parent = new Virus(1.5, 5, "VirusPetya", "123");
        parent.AddChild(new Virus(0.5, 2, "VirusVasya", "123"));
        parent.Children[0].AddChild(new Virus(0.2, 1, "VirusVitya", "123"));

        Virus shallowClone = parent.ShallowCopy();
        Virus deepClone = parent.DeepCopy();

        Console.WriteLine("Original parent and its children:");
        DisplayVirus(parent);

        Console.WriteLine("\nShallow clone and its children:");
        DisplayVirus(shallowClone);

        Console.WriteLine("\nDeep clone and its children:");
        DisplayVirus(deepClone);

        parent.Age = 6;
        parent.Children[0].Name = "VirusVityaBeta";

        Console.WriteLine("\nAfter modifications to original:");
        Console.WriteLine("Original parent and its children:");
        DisplayVirus(parent);

        Console.WriteLine("\nShallow clone and its children (references to children have changed):");
        DisplayVirus(shallowClone);

        Console.WriteLine("\nDeep clone and its children (remains unchanged):");
        DisplayVirus(deepClone);
    }

    static void DisplayVirus(Virus virus)
    {
        Console.WriteLine($"Name: {virus.Name}, Age: {virus.Age}, Species: {virus.Species}");
        foreach (Virus child in virus.Children)
        {
            Console.WriteLine($"  Child Name: {child.Name}, Age: {child.Age}, Species: {child.Species}");
        }
    }
}