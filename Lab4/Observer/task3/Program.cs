using ClassLibrary;
using ClassLibrary.EventListeners;

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

        ClickListener clickListener = new ClickListener();
        MouseOverListener mouseOverListener = new MouseOverListener();

        div.Subscribe(mouseOverListener);
        div.Notify();
        Console.WriteLine();

        div.Subscribe(clickListener);
        div.Notify();
        Console.WriteLine();

        div.Unsubscribe(clickListener);
        div.Notify();
        Console.WriteLine();

        Console.WriteLine("OuterHTML of div:");
        Console.WriteLine(div.ToHtml());
    }
}