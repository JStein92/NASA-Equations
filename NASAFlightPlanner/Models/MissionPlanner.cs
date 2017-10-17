using System;
namespace NASAFlightPlanner.Models
{
    public class MissionPlanner
    {
        public int GetAstronautsNeeded(int days, int tasksToComplete)
        {
            int hours = days * 16;
            int tasksPossiblePerAstronaut = hours * 11;
            double astronautsNeeded = (double)tasksToComplete/tasksPossiblePerAstronaut;

			double efficiencyGains = 0;
            for (int i = 1; i < Math.Floor(astronautsNeeded); i++)
			{
				efficiencyGains += 0.2;
			}

            astronautsNeeded = astronautsNeeded / (1 + efficiencyGains);

            return (int)Math.Ceiling(astronautsNeeded);
          
        }
    }
}
