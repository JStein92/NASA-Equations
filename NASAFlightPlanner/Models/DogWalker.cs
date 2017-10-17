using System;
namespace NASAFlightPlanner.Models
{
    public class DogWalker
    {
        public int rate { get; set; }
        public int hoursAvailable { get; set; }
        public int profit { get; set; }

		public int maxPossibleDailyProfit()
		{
            return this.rate * this.hoursAvailable;
		}

        public int profitOverDays(int days)
        {
            this.profit = this.maxPossibleDailyProfit() * days;
            return this.profit;
        }

    }
}
