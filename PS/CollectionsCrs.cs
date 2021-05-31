using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedC.PS
{
    public class CollectionsCrs
    {
        public static void CollectionsFunc() {
            string[] daysOfWeek = {
            "Sunday","Monday","Tuesday","Wednesday","Thrusday","Friday","Saturday"
        };
            Console.WriteLine($"Last Day is" + daysOfWeek[^1]);

            Dictionary<string, string> countries = new Dictionary<string, string>();
            countries.Add("NOR", "NOR Name");
            countries.Add("EGY", "EGY Name");
            countries.Add("FIN", "FIN Name");

            foreach (var country in countries)
            {
                Console.WriteLine(country.Key + country.Value);
            }

            for (int i = 0; i < countries.Count; i++)
            {

            }

            // backword loop

            for (int i = countries.Count -1; i >= 0; i--)
            {

            }

            Dictionary dic = new System.Collections.Generic.Dictionary();


        }
    }
}
