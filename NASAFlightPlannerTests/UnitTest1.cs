using Microsoft.VisualStudio.TestTools.UnitTesting;
using NASAFlightPlanner.Models;

namespace NASAFlightPlannerTests
{
    [TestClass]
    public class MissionTest
    {
        [TestMethod]
        public void TestAstronautsNeeded()
        {
            var mission = new MissionPlanner();

            var days = 3;
            var tasksToComplete = 1200;

            var result = mission.GetAstronautsNeeded(days,tasksToComplete);
            Assert.AreEqual(2, result);    
        }

    }
}
