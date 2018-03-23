using System;

namespace RectangleArea
{
    class RectangleArea
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = width * height;
            Console.WriteLine($"{area:F2}");
        }
    }
}
