using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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

        /// <summary>
        /// Transforms the wine.csv file into a file that can be queried by user input.
        /// </summary>
        /// <param name="name">Brings in the user entered name</param>
        /// <param name="maxPrice">Brings in the user entered maximum price of the wine</param>
        /// <param name="minPoints">Brings in the user entered minimum point score of the wine</param>
        /// <returns></returns>
        public static List<Wine> GetWineList(string name, int maxPrice, int minPoints)
        {
            List<Wine> wine = new List<Wine>();
            string path = "../DontWineAboutIt/wwwroot/wine.csv";
            string[] wines = File.ReadAllLines(path);
            for (int i = 0; i < wines.Length; i++)
            {
                var regex = new Regex("(?<=^|,)(\"(?:[^\"]|\"\")*\"|[^,]*)");
                foreach (Match wineEntry in regex.Matches(wines[i]))
                {
                    var wineLine = wineEntry.Value;
                    wines[i] = wineLine;
                }
            }
            for (int j = 0; j < wines.Length; j++)
            {
                wine.Add(new Wine
                {
                    Number = wines[0],
                    Country = wines[1],
                    Description = wines[2],
                    Designation = wines[3],
                    Points = wines[4],
                    Price = wines[5],
                    Province = wines[6],
                    Region_1 = wines[7],
                    Region_2 = wines[8],
                    Variety = wines[9],
                    Winery = wines[10],
                });
            }
            return wine;
            /*
            using (StreamReader sr = File.OpenText(path))
            {
                
                
                /*
                var regex = new Regex("(?<=^|,)(\"(?:[^\"]|\"\")*\"|[^,]*)");
                foreach (Match wineEntry in regex.Matches(path))
                {
                    var s = wineEntry.Value;
                }
                */
                /*
                List<Wine> wines = new List<Wine>();
                var wineList = sr.ReadToEnd();

                var regex = new Regex("(?<=^|,)(\"(?:[^\"]|\"\")*\"|[^,]*)");


                foreach (Match wine in regex.Matches(wineList))
                //for (int i = 0; i < 100; i++)
                {
                    //Wine newWine = new Wine();
                    //newWine.Number = regex;
                    //List<Wine> wines = wine.Value;
                    var wineResults = wine.Value;
                }
                
                return wine;
                
            }
            */
        }
        /*
        public static Wine SelectWines(int maxPrice, int minPoints)
        {

        }
*/

    }
}
