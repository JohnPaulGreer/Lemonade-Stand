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
            Console.WriteLine("How many lemonade stands would you like to open?");

            int numberOfLemonadeStands = inputInstance.GetUserInegerInput(Console.ReadLine());
            List<LemonadeStand> locations = new List<LemonadeStand>();

            for (int i = 0; i < numberOfLemonadeStands; i++)
            {
                LemonadeStand lemonadeStand = new LemonadeStand();

                lemonadeStand.name = lemonadeStand.GetUserStringResponse("What is the name of your lemonade stand?");
                lemonadeStand.numOfCups = lemonadeStand.GetUserInegerInput("How many cups will you sell?");
                lemonadeStand.pricePerCup = lemonadeStand.GetUserDoubleInput("How much will you charge per cup?");
                lemonadeStand.costPerCup = lemonadeStand.GetUserDoubleInput("How much will you spend to produce the lemonade?");

                Console.WriteLine();
                Console.WriteLine("After calculating all of your inputs...");
                Console.WriteLine();
                Console.WriteLine(lemonadeStand.name + " sounds like a good name for your lemonade stand.");
                Console.WriteLine();
                Console.WriteLine("If you are going to sell " + lemonadeStand.numOfCups + " cups of lemonade");
                Console.WriteLine("and you are charging $" + lemonadeStand.pricePerCup + " ");
                Console.WriteLine("and it costs you $" + lemonadeStand.costPerCup + " per cup of lemonade.");
                Console.WriteLine();
                lemonadeStand.revenue = lemonadeStand.numOfCups * lemonadeStand.pricePerCup;
                lemonadeStand.totalExpenses = lemonadeStand.numOfCups * lemonadeStand.costPerCup;
                lemonadeStand.totalProfit = lemonadeStand.revenue - lemonadeStand.totalExpenses;

                Console.WriteLine("Your total revenue will be $" + lemonadeStand.revenue);
                Console.WriteLine("Your total expnses will be $" + lemonadeStand.totalExpenses);
                Console.WriteLine("Your total profit will be $" + lemonadeStand.totalProfit);
                Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}
