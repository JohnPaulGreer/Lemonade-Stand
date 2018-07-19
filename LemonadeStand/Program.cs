using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            LemonadeStand inputInstance = new LemonadeStand();

            Console.WriteLine("Welcome!");
            int numberOfLemonadeStands = inputInstance.GetUserInegerInput("How many lemonade stands would you like to open?");

            List<LemonadeStand> locations = new List<LemonadeStand>();

            for (int i = 0; i < numberOfLemonadeStands; i++)
            {
                LemonadeStand lemonadeStand = new LemonadeStand();

                Console.WriteLine("What is the name of the location " + (i + 1) + "?");
                lemonadeStand.name = Console.ReadLine();

                lemonadeStand.numOfCups = lemonadeStand.GetUserInegerInput("How many cups will you sell?");
                lemonadeStand.pricePerCup = lemonadeStand.GetUserDoubleInput("How much will you charge per cup?");
                lemonadeStand.costPerCup = lemonadeStand.GetUserDoubleInput("How much will you spend to produce the lemonade?");

                Console.WriteLine();
                Console.WriteLine("After calculating all of your inputs...");
                Console.WriteLine();
                Console.WriteLine(lemonadeStand.name + " sounds like a good name for this lemonade stand.");
                Console.WriteLine();
                Console.WriteLine("If you are going to sell " + lemonadeStand.numOfCups + " cups of lemonade");
                Console.WriteLine("and you are charging $" + lemonadeStand.pricePerCup + " ");
                Console.WriteLine("and it costs you $" + lemonadeStand.costPerCup + " per cup of lemonade.");
                Console.WriteLine();
                Console.WriteLine("This stand's revenue will be $" + lemonadeStand.totalRevenue());
                Console.WriteLine("This stand's expenses will be $" + lemonadeStand.totalExpenses());
                Console.WriteLine("This stand's profit will be $" + lemonadeStand.totalProfit());
                Console.WriteLine();

                locations.Add(lemonadeStand);
            }

            Console.ReadLine();
        }
    }
}
