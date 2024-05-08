using ClassLibrary;

public class Program
{
    public static void Main()
    {
        IRender rasterRender = new RasterRender();
        IRender vectorRender = new VectorRender();

        Circle circle = new Circle(rasterRender);
        Square square = new Square(vectorRender);
        Triangle triangle = new Triangle(vectorRender);

        circle.Operation();
        square.Operation();
        triangle.Operation();
    }
}