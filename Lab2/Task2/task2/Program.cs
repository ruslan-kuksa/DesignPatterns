using ClassLibrary.Classes.IProneFactory;
using ClassLibrary.Classes.BalaxyFactory;
using ClassLibrary.Classes.KiaomiFactory;
using ClassLibrary.Interfaces;
using ClassLibrary;

class Program
{
    static void Main()
    {
        IDevicesFactory factory = new IProneFactory();
        ILaptop laptop = factory.CreateLaptop();
        INetbook netbook = factory.CreateNetbook();
        IEBook ebook = factory.CreateEBook();
        ISmartphone smartphone = factory.CreateSmartphone();

        Console.WriteLine(laptop.UsefulFunctionLaptop());
        Console.WriteLine(netbook.UsefulFunctionNetbook());
        Console.WriteLine(ebook.UsefulFunctionEBook());
        Console.WriteLine(smartphone.UsefulFunctionSmartphone());
        Console.WriteLine();
        IDevicesFactory factory2 = new BalaxyFactory();
        ILaptop laptop2 = factory2.CreateLaptop();
        INetbook netbook2 = factory2.CreateNetbook();
        IEBook ebook2 = factory2.CreateEBook();
        ISmartphone smartphone2 = factory2.CreateSmartphone();

        Console.WriteLine(laptop2.UsefulFunctionLaptop());
        Console.WriteLine(netbook2.UsefulFunctionNetbook());
        Console.WriteLine(ebook2.UsefulFunctionEBook());
        Console.WriteLine(smartphone2.UsefulFunctionSmartphone());
    }
}
