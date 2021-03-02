using System;

namespace Money_Maker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Capture Input 
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("How much would you like to convert?");
            string moneyStr = Console.ReadLine();
            double moneyDouble = Convert.ToDouble(moneyStr);

            Console.WriteLine($"{moneyStr} cents is equal to...");

            // Convert to coins
            int goldValue = 10;
            int silverValue = 5;

            double goldCoins = Math.Floor(moneyDouble / goldValue);
            double reminder = moneyDouble % goldValue;

            double silverCoins = Math.Floor(reminder / silverValue);
            reminder = reminder % silverValue;

            // Capture output
            Console.WriteLine($"Gold coins: {goldCoins}");
            Console.WriteLine($"Silver coins: {silverCoins}");
            Console.WriteLine($"Bronze coins: {reminder}");
        }
    }
}
