using System;

namespace LemonadeStand
{
    class Program
    {
        static string GetUserStringResponse(string question)
        {
            Console.WriteLine(question);
            string response = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(response))
            {
                Console.WriteLine("Please enter an answer. " + question);
                response = Console.ReadLine();
            }

            return response;
        }

        static int GetUserInegerInput(string question)
        {
            Console.WriteLine(question);
            int response;
            while (!int.TryParse(Console.ReadLine(), out response))
            {
                Console.WriteLine("Unable to determine response. " + question);
            }

            return response;
        }

        static double GetUserDoubleInput(string question)
        {
            Console.WriteLine(question);
            double response;
            while (!double.TryParse(Console.ReadLine(), out response))
            {
                Console.WriteLine("Unable to determine response. " + question);
            }

            return response;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine();
            string name = GetUserStringResponse("What is the name of your lemonade stand?");
            int numOfCups = GetUserInegerInput("How many cups will you sell?");
            double pricePerCup = GetUserDoubleInput("How much will you charge per cup?");
            double costPerCup = GetUserDoubleInput("How much will you spend to produce the lemonade?");

            Console.WriteLine();
            Console.WriteLine("After calculating all of your inputs...");
            Console.WriteLine("Recap:");
            Console.WriteLine();
            Console.WriteLine(name + " sounds like a good name for your lemonade stand.");
            Console.WriteLine();
            Console.WriteLine("If you are going to sell " + numOfCups + " cups of lemonade");
            Console.WriteLine("and you are charging $" + pricePerCup + " ");
            Console.WriteLine("and it costs you $" + costPerCup + " per cup of lemonade.");
            Console.WriteLine();

            var revenue = numOfCups * pricePerCup;
            Console.WriteLine("Then the total amount of money the lemonade stand would bring in is $" + revenue + " ");

            var net = revenue - costPerCup * numOfCups;
            Console.WriteLine("and total profit for the lemonade stand per " + numOfCups + " cups is $" + net + ".");

            Console.ReadLine();
        }
    }
}
