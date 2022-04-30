using DAL.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class WeatherApi
    {
           
        public CityTemperatureModel GetWeather(string cityName)
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/forecast?id=524901&appid=f4b61da4bd8cbd9e4917a2c479fbb04f&q={0}", cityName);
                var json = web.DownloadString(url);
                var result = JsonConvert.DeserializeObject<CityTemperatureModel>(json);

                return result!;
            }

        }
    }
}
