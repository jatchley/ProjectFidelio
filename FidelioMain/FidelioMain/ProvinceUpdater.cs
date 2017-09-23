using System;
using System.Collections.Generic;
using System.Text;

namespace Fidelio
{
    public class ProvinceUpdater : IDailyTick
    {
        public List<Province> provinces;

        public ProvinceUpdater(List<Province> allProvinces)
        {
            provinces = allProvinces;
        }

        public void DailyTickUpdate()
        {
            foreach (var province in provinces)
            {
                province.UpdatePopulation();
            }
        }
    }
}
