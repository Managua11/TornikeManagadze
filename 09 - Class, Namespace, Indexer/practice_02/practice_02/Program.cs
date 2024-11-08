using Practice;

namespace Practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();

            Console.Write("Enter side 1: ");
            triangle.Side1 = int.Parse(Console.ReadLine());

            Console.Write("Enter side 2: ");
            triangle.Side2 = int.Parse(Console.ReadLine());

            Console.Write("Enter side 3: ");
            triangle.Side3 = int.Parse(Console.ReadLine());

            if (triangle.Perimeter() > 0)
            {
                Console.WriteLine($"Perimeter of the triangle is: {triangle.Perimeter()}");
                Console.WriteLine($"Area of the triangle is: {triangle.Area():F2}"); // 2 precision, cudi ricxvebis shemtxvevashi
            }
        }
    }
}

