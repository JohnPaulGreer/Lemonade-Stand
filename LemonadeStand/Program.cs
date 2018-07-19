using System;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            LemonadeStand lemonadeStand = new LemonadeStand();
            Console.WriteLine("Welcome!");

            lemonadeStand.name = lemonadeStand.GetUserStringResponse("What is the name of your lemonade stand?");
            lemonadeStand.numOfCups = lemonadeStand.GetUserInegerInput("How many cups will you sell?");
            lemonadeStand.pricePerCup = lemonadeStand.GetUserDoubleInput("How much will you charge per cup?");
            lemonadeStand.costPerCup = lemonadeStand.GetUserDoubleInput("How much will you spend to produce the lemonade?");

            Console.WriteLine();
            Console.WriteLine("After calculating all of your inputs...");
            Console.WriteLine("Recap:");
            Console.WriteLine();
            Console.WriteLine(lemonadeStand.name + " sounds like a good name for your lemonade stand.");
            Console.WriteLine();
            Console.WriteLine("If you are going to sell " + lemonadeStand.numOfCups + " cups of lemonade");
            Console.WriteLine("and you are charging $" + lemonadeStand.pricePerCup + " ");
            Console.WriteLine("and it costs you $" + lemonadeStand.costPerCup + " per cup of lemonade.");
            Console.WriteLine();

            var revenue = lemonadeStand.numOfCups * lemonadeStand.pricePerCup;
            Console.WriteLine("Then the total amount of money the lemonade stand would bring in is $" + revenue + " ");

            var net = revenue - lemonadeStand.costPerCup * lemonadeStand.numOfCups;
            Console.WriteLine("and total profit for the lemonade stand per " + lemonadeStand.numOfCups + " cups is $" + net + ".");

            Console.ReadLine();
        }
    }
}
