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
    }
}
