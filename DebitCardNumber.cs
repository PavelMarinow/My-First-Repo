using System;

namespace DebitCardNumber
{
    class DebitCardNumber
    {
        static void Main(string[] args)
        {
			//Reading the input from the console.
            int firstDigits = int.Parse(Console.ReadLine());
            int secondDigits = int.Parse(Console.ReadLine());
            int thirdDigits = int.Parse(Console.ReadLine());
            int fourthDigits = int.Parse(Console.ReadLine());
			
			//Writing the output on the console
            Console.Write($"{firstDigits:D4} {secondDigits:D4} {thirdDigits:D4} {fourthDigits:D4}");
        }
    }
}
