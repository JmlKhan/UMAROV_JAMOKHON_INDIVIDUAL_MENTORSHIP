using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services
{
    public class Validate
    {
        public string CheckCity(string cityName)
        {
            var weatherObject = new WeatherApi();
            var result = weatherObject.GetWeather(cityName);

            if(cityName.Length == 0)
            {
                return "enter city name";
            }
            
            return result.list[0]!.main!.temp.ToString();
        }
    }
}
