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

                Console.WriteLine("What is the name of location " + (i + 1) + "?");
                lemonadeStand.name = Console.ReadLine();

                lemonadeStand.numOfCups = lemonadeStand.GetUserInegerInput("How many cups will you sell?");
                lemonadeStand.pricePerCup = lemonadeStand.GetUserDoubleInput("How much will you charge per cup?");
                lemonadeStand.costPerCup = lemonadeStand.GetUserDoubleInput("How much will you spend on lemonade?");

                Console.WriteLine();
                Console.WriteLine("After calculating all of your inputs...");
                Console.WriteLine();
                Console.WriteLine(lemonadeStand.name + " sounds like a good name for this stand.");
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

            PopsicleStand inputInstance1 = new PopsicleStand();

            Console.WriteLine("Welcome!");
            int numberOfPopsicleStands = inputInstance1.GetUserInegerInput("How many popsicle stands would you like to open?");

            List<PopsicleStand> locations1 = new List<PopsicleStand>();

            for (int i = 0; i < numberOfPopsicleStands; i++)
            {
                PopsicleStand popsicleStand = new PopsicleStand();

                Console.WriteLine("What is the name of location " + (i + 1) + "?");
                popsicleStand.name = Console.ReadLine();

                popsicleStand.numOfPopsicles = popsicleStand.GetUserInegerInput("How many popsicles will you sell?");
                popsicleStand.pricePerPopsicle = popsicleStand.GetUserDoubleInput("How much will you charge per popsicle?");
                popsicleStand.costPerPopsicle = popsicleStand.GetUserDoubleInput("How much will you spend on the popsicles?");

                Console.WriteLine();
                Console.WriteLine("After calculating all of your inputs...");
                Console.WriteLine();
                Console.WriteLine(popsicleStand.name + " sounds like a good name for this stand.");
                Console.WriteLine();
                Console.WriteLine("If you are going to sell " + popsicleStand.numOfPopsicles + " popsicles");
                Console.WriteLine("and you are charging $" + popsicleStand.pricePerPopsicle + " ");
                Console.WriteLine("and it costs you $" + popsicleStand.costPerPopsicle + " per popsicle.");
                Console.WriteLine();
                Console.WriteLine("This stand's revenue will be $" + popsicleStand.totalRevenue());
                Console.WriteLine("This stand's expenses will be $" + popsicleStand.totalExpenses());
                Console.WriteLine("This stand's profit will be $" + popsicleStand.totalProfit());
                Console.WriteLine();

                locations1.Add(popsicleStand);
            }

            Console.ReadLine();
        }
    }
}
