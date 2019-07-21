using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartsApplication.Models
{
    public class PopulationDataAccessLayer
    {
        public static List<populationModel> GetCityPopulationList()
        {
            var list = new List<populationModel>();
            list.Add(new populationModel { cityName = "London", PopulationYear2020 = 28000, PopulationYear2000 = 45000, PopulationYear2010 = 22000, PopulationYear1990 = 50000 });

            list.Add(new populationModel { cityName = "Bhubaneswar", PopulationYear2020 = 30000, PopulationYear2010 = 49000, PopulationYear2000 = 24000, PopulationYear1990 = 39000 });
            list.Add(new populationModel { cityName = "Cuttack", PopulationYear2020 = 35000, PopulationYear2010 = 56000, PopulationYear2000 = 26000, PopulationYear1990 = 41000 });
            list.Add(new populationModel { cityName = "Berhampur", PopulationYear2020 = 37000, PopulationYear2010 = 44000, PopulationYear2000 = 28000, PopulationYear1990 = 48000 });
            list.Add(new populationModel { cityName = "Odisha", PopulationYear2020 = 40000, PopulationYear2010 = 38000, PopulationYear2000 = 30000, PopulationYear1990 = 54000 });

            return list;
        }
    }
}
