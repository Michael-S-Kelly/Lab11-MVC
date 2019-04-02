using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DontWineAboutIt.Models
{
    public class Wine
    {
        public string Number { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public string Designation { get; set; }
        public string Points { get; set; }
        public string Price { get; set; }
        public string Province { get; set; }
        public string Region_1 { get; set; }
        public string Region_2 { get; set; }
        public string Variety { get; set; }
        public string Winery { get; set; }

        public static string[] GetWineList()
        {
            string path = "~/wine.csv";
            string[] wineList = File.ReadAllLines(path);

            return wineList;
        }
    }
}
