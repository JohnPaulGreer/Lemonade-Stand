using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class MultiStand
    {
        public string name { get; set; }
        public int numOfItems { get; set; }
        public double pricePerItem { get; set; }
        public double costPerItem { get; set; }

        public double totalRevenue()
        {
            return numOfItems * pricePerItem;
        }
        public double totalExpenses()
        {
            return numOfItems * costPerItem;
        }
        public double totalProfit()
        {
            return totalRevenue() - totalExpenses();
        }

        public string GetUserStringResponse(string question)
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

        public int GetUserInegerInput(string question)
        {
            Console.WriteLine(question);
            int response;
            while (!int.TryParse(Console.ReadLine(), out response))
            {
                Console.WriteLine("Unable to determine response. " + question);
            }

            return response;
        }

        public double GetUserDoubleInput(string question)
        {
            Console.WriteLine(question);
            double response;
            while (!double.TryParse(Console.ReadLine(), out response))
            {
                Console.WriteLine("Unable to determine response. " + question);
            }

            return response;
        }
    }
}
