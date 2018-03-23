using System;

namespace MilesToKilometers
{
    class MilesToKilometers
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());
            double kilometers = miles * 1.60934;

            Console.Write($"{kilometers:F2}");
        }
    }
}
