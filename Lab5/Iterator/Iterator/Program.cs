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

        LightElementNode div2 = new LightElementNode("div", true, false);

        LightElementNode header = new LightElementNode("header", true, false);
        div2.AddChild(header);
        header.AddChild(new LightTextNode("Welcome to My Website"));

        LightElementNode main = new LightElementNode("main", true, false);
        div2.AddChild(main);

        LightElementNode section = new LightElementNode("section", true, false);
        main.AddChild(section);
        section.AddChild(new LightTextNode("section inside the content"));

        LightElementNode footer = new LightElementNode("footer", true, false);
        div2.AddChild(footer);
        footer.AddChild(new LightTextNode("Footer content goes here."));

        Console.WriteLine();
        LightHTMLIterator dfsIterator = div2.GetDepthFirstIterator();
        Console.WriteLine("DFS:");
        while (dfsIterator.MoveNext())
        {
            Console.WriteLine(dfsIterator.Current.ToHtml());
        }

        Console.WriteLine();
        LightHTMLIterator bfsIterator = div2.GetBreadthFirstIterator();
        Console.WriteLine("BFS:");
        while (bfsIterator.MoveNext())
        {
            Console.WriteLine(bfsIterator.Current.ToHtml());
        }
    }
}