using ClassLibrary;

public class Program
{
    public static void Main()
    {
        LightElementNode div = new LightElementNode("div", isBlock: true, isSelfClosing: false);
        div.AddClass("container");

        LightElementNode p = new LightElementNode("p", isBlock: true, isSelfClosing: false);
        p.AddChild(new LightTextNode("Це простий параграф з текстом."));
        div.AddChild(p);

        LightElementNode img = new LightElementNode("img", isBlock: false, isSelfClosing: true);
        img.AddClass("thumbnail");
        div.AddChild(img);

        Console.WriteLine("InnerHTML of div:");
        Console.WriteLine(div.InnerHTML());
        Console.WriteLine("OuterHTML of div:");
        Console.WriteLine(div.OuterHTML());
        Console.WriteLine();

        LightElementNode div2 = new LightElementNode("div", true, false);
        CommandInvoker invoker = new CommandInvoker();

        ICommand addClassCommand = new AddClassCommand(div2, "container2");
        invoker.ExecuteCommand(addClassCommand);

        Console.WriteLine(div2.ToHtml());

        invoker.Undo();
        Console.WriteLine(div2.ToHtml());

        ICommand removeClassCommand = new RemoveClassCommand(div2, "container2");
        invoker.ExecuteCommand(removeClassCommand);

        invoker.Undo();
        Console.WriteLine(div2.ToHtml());
    }
}