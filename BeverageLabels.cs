using System;

namespace BeverageLabels
{
    class BeverageLabels
    {
        static void Main(string[] args)
        {
            string name = (Console.ReadLine());
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());

            double totalEnergy = energy * (volume / 100.0);
            double totalSugar = sugar * (volume / 100.0);

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{totalEnergy}kcal, {totalSugar}g sugars");
        }
    }
}
