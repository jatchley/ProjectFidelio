using System;
using System.Collections.Generic;

namespace Fidelio
{
    public class Program
    {
        static void Main(string[] args)
        {
            Province testProvince1 = new Province(1, 10000, 0.01);
            Province testProvince2 = new Province(2, 50000, 0.06);

            List<Province> allProvinces = new List<Province>();
            allProvinces.Add(testProvince1);
            allProvinces.Add(testProvince2);

            ProvinceUpdater provinceUpdater = new ProvinceUpdater(allProvinces);

            bool keepRunning = true;
            while (keepRunning)
            {
                provinceUpdater.DailyTickUpdate();
                foreach (var province in allProvinces)
                {
                    Console.WriteLine("Province ID: " + province.ID);
                    Console.WriteLine("Province Population: " + province.Population);
                }
                string input = Console.ReadLine();
                keepRunning = input == "n" ? false : true;
            }
        }
    }
}
