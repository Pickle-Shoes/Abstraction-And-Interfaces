using Abstraction_And_Interfaces.Shapes;

namespace Abstraction_And_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle(5);
            Console.WriteLine($"Circle area: {circle.CalculateArea()}");
            Console.WriteLine($"Circle perimeter: {circle.CalculatePerimeter()}");
            IShape rectangle = new Rectangle(5, 2);
            Console.WriteLine($"Rectangle area: {rectangle.CalculateArea()}");
            Console.WriteLine($"Rectangle perimeter: {rectangle.CalculatePerimeter()}");
        }
    }
}
