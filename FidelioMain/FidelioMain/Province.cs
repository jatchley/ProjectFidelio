using System;
using System.Collections.Generic;
using System.Text;

namespace Fidelio
{
    public class Province
    {
        public int ID { get; set; }
        public int Population { get; set; }
        public double GrowthRate { get; set; }

        public Province(int id, int pop, double growthRate)
        {
            ID = id;
            Population = pop;
            GrowthRate = growthRate;
        }

        public void UpdatePopulation()
        {
            // TODO: Change from 0.01 to actual population increase rate

            Population = Population + Convert.ToInt32(Math.Round(Population * GrowthRate));
        }
    }
}
