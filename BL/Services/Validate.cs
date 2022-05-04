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
        public async Task<string> CheckCity(string cityName)
        {
            //if (cityName.Length == 0)
            //{
            //    return "enter city name";
            //}
            var weatherObject = new WeatherApi();
            var result = await weatherObject.GetWeatherAsync(cityName);

           

            return result!.list[0]!.main!.temp.ToString();
        }
    }
}
