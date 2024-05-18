using ClassLibrary;

public class Program
{
    public static void Main()
    {
        LightTextNode textNode = new LightTextNode("Template Method");
        LightElementNode elementNode = new LightElementNode("div", true, false);
        elementNode.AddClass("container");
        elementNode.AddChild(textNode);

        Console.WriteLine(elementNode.TemplateMethod());
    }
}