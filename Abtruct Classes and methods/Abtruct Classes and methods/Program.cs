using Abtruct_Classes_and_methods;


class Program
{
    static void Main(string[] args)
    {

        Circle circle = new Circle(5.0);
        Console.WriteLine("Circle area: " + circle.GetArea());

        Rectangle rectangle = new Rectangle(4.0, 6.0);
        Console.WriteLine("Rectangle area: " + rectangle.GetArea());
    }
}