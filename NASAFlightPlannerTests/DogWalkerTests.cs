using Microsoft.VisualStudio.TestTools.UnitTesting;
using NASAFlightPlanner.Models;

namespace NASAFlightPlannerTests
{
	[TestClass]
	public class DogWalkerTests
	{
		[TestMethod]
		public void TestMaxProfitPossible()
		{
            var newWalker = new DogWalker();
            newWalker.rate = 5;
            newWalker.hoursAvailable = 5;
            var actual = newWalker.maxPossibleDailyProfit();
            Assert.AreEqual(25,actual);
		}

        [TestMethod]
        public void TextProfitOverDays()
        {
            var newWalker = new DogWalker();
            newWalker.rate = 20;
            newWalker.hoursAvailable = 6;
            var actual = newWalker.profitOverDays(5);
            Assert.AreEqual(600, actual);
        }
	}
}
