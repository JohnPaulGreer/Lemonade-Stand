using System;
using System.Collections.Generic;
namespace LemonadeStand
{
    class LemonadeStandCorporation
    {
        public string Name { get; set; }
        public List<LemonadeStand> Locations { get; set; } = new List<LemonadeStand>();

        public double GetTotalRevenue()
        {
            double grandTotal = 0;
            foreach(LemonadeStand location in Locations)
            {
                grandTotal += location.totalRevenue();
            }
            return grandTotal;
        }

        public double GetTotalExpense()
        {
            double grandTotal = 0;
            foreach (LemonadeStand location in Locations)
            {
                grandTotal += location.totalExpenses();
            }
            return grandTotal;
        }

        public double GetTotalProfit()
        {
            double grandTotal = 0;
            foreach (LemonadeStand location in Locations)
            {
                grandTotal += location.totalProfit();
            }
            return grandTotal;
        }
    }
}
