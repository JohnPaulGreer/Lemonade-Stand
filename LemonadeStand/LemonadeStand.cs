using System;
namespace LemonadeStand
{
    class LemonadeStand
    {
		public string name  { get; set; }
        public int numOfCups { get; set; }
        public double pricePerCup { get; set; }
        public double costPerCup { get; set; }

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
