using System;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            LemonadeStand lemonadeStand1 = new LemonadeStand();
            LemonadeStand lemonadeStand2 = new LemonadeStand();

            Console.WriteLine("Welcome!");

            lemonadeStand1.name = lemonadeStand1.GetUserStringResponse("What is the name of your lemonade stand?");
            lemonadeStand1.numOfCups = lemonadeStand1.GetUserInegerInput("How many cups will you sell?");
            lemonadeStand1.pricePerCup = lemonadeStand1.GetUserDoubleInput("How much will you charge per cup?");
            lemonadeStand1.costPerCup = lemonadeStand1.GetUserDoubleInput("How much will you spend to produce the lemonade?");

            Console.WriteLine();
            Console.WriteLine("After calculating all of your inputs...");
            Console.WriteLine();
            Console.WriteLine(lemonadeStand1.name + " sounds like a good name for your lemonade stand.");
            Console.WriteLine();
            Console.WriteLine("If you are going to sell " + lemonadeStand1.numOfCups + " cups of lemonade");
            Console.WriteLine("and you are charging $" + lemonadeStand1.pricePerCup + " ");
            Console.WriteLine("and it costs you $" + lemonadeStand1.costPerCup + " per cup of lemonade.");
            Console.WriteLine();
            lemonadeStand1.revenue = lemonadeStand1.numOfCups * lemonadeStand1.pricePerCup;
            lemonadeStand1.totalExpenses = lemonadeStand1.numOfCups * lemonadeStand1.costPerCup;
            lemonadeStand1.totalProfit = lemonadeStand1.revenue - lemonadeStand1.totalExpenses;

            Console.WriteLine("Your total revenue will be " + lemonadeStand1.revenue);
            Console.WriteLine("Your total expnses will be " + lemonadeStand1.totalExpenses);
            Console.WriteLine("Your total profit will be " + lemonadeStand1.totalProfit);




            Console.WriteLine("Welcome!");

            lemonadeStand2.name = lemonadeStand2.GetUserStringResponse("What is the name of your lemonade stand?");
            lemonadeStand2.numOfCups = lemonadeStand2.GetUserInegerInput("How many cups will you sell?");
            lemonadeStand2.pricePerCup = lemonadeStand2.GetUserDoubleInput("How much will you charge per cup?");
            lemonadeStand2.costPerCup = lemonadeStand2.GetUserDoubleInput("How much will you spend to produce the lemonade?");

            Console.WriteLine();
            Console.WriteLine("After calculating all of your inputs...");
            Console.WriteLine();
            Console.WriteLine(lemonadeStand2.name + " sounds like a good name for your lemonade stand.");
            Console.WriteLine();
            Console.WriteLine("If you are going to sell " + lemonadeStand2.numOfCups + " cups of lemonade");
            Console.WriteLine("and you are charging $" + lemonadeStand2.pricePerCup + " ");
            Console.WriteLine("and it costs you $" + lemonadeStand2.costPerCup + " per cup of lemonade.");
            Console.WriteLine();
            lemonadeStand2.revenue = lemonadeStand2.numOfCups * lemonadeStand2.pricePerCup;
            lemonadeStand2.totalExpenses = lemonadeStand2.numOfCups * lemonadeStand2.costPerCup;
            lemonadeStand2.totalProfit = lemonadeStand2.revenue - lemonadeStand2.totalExpenses;

            Console.WriteLine("Your total revenue will be " + lemonadeStand2.revenue);
            Console.WriteLine("Your total expnses will be " + lemonadeStand2.totalExpenses);
            Console.WriteLine("Your total profit will be " + lemonadeStand2.totalProfit);
            Console.ReadLine();

            //lemonadeStand2.revenue = lemonadeStand2.numOfCups * lemonadeStand2.pricePerCup;
            //Console.WriteLine("Then the total amount of money the lemonade stand would bring in is $" + lemonadeStand2.revenue + " ");

            //lemonadeStand2.net = lemonadeStand2.revenue - lemonadeStand2.costPerCup * lemonadeStand2.numOfCups;
            //Console.WriteLine("and total profit for the lemonade stand per " + lemonadeStand2.numOfCups + " cups is $" + lemonadeStand2.net + ".");

        }
    }
}
