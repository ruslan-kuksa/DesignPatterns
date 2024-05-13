using ClassLibrary;

class Program
{
    public static void Main()
    {
        TextEditor editor = new TextEditor();
        editor.WriteText("Hello, world!");
        editor.WriteText("world! Hello");
        editor.WriteText("Hello, ");
        editor.WriteText("world!");
        editor.ShowContent();
        editor.Undo();
        editor.ShowContent();
        editor.Undo();
        editor.ShowContent();
    }
}