using ClassLibrary;

class Program
{
    public static void Main()
    {
        Image image = new Image();
        image.Load("https://mil.in.ua/wp-content/uploads/2022/10/1.jpg");
        image.Load("C:\\Users\\Admin\\Desktop\\IMG_20221008_093101_085.jpg");
    }
}