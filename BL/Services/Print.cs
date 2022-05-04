using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services
{
    public class Print
    {
        public async Task Response(string cityName)
        {
            var validateCity = new Validate();
            var temp = Convert.ToDouble(await validateCity.CheckCity(cityName));

            var celcius = temp - 273.15;
            string comment;
            
            if(0 >= celcius)
            {
                comment = "Dress warmly";
            }
            else if (20 >= celcius)
            {
                comment = "Its Fresh";
            }
                
            else if (30 >= celcius)
            {
                comment = "Good weather";
            }
            else
            {
                comment = "it's time to go to the beach";
            }
            Console.WriteLine("temperature is {0:00.0} C in {1}. {2}",celcius, cityName, comment);

        }
    }
}
