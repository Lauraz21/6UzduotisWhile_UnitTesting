using System;
namespace _6UzduotisWhile_UnitTesting
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("iveskite skaiciu: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Rezultatas: " + CalculateFactorial(userInput));
        }
        public static int CalculateFactorial (int num)
        {
            int sum = num;

            int i = num;

            while (i > 1)
            {
                i--;
                sum = sum * i;
            }
            return sum;
        }
    }
}
