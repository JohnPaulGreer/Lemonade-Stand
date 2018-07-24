using System;
namespace LemonadeStand
{
    class PopsicleStand
    {
        public string name { get; set; }
        public int numOfPopsicles { get; set; }
        public double pricePerPopsicle { get; set; }
        public double costPerPopsicle { get; set; }

        public double totalRevenue()
        {
            return numOfPopsicles * pricePerPopsicle;
        }
        public double totalExpenses()
        {
            return numOfPopsicles * costPerPopsicle;
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
