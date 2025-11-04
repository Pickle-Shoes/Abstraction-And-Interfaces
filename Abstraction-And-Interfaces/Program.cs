using Abstraction_And_Interfaces.Shapes;

namespace Abstraction_And_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape shape = new Circle(5);
            Console.WriteLine(shape.CalculateArea());
        }
    }
}
