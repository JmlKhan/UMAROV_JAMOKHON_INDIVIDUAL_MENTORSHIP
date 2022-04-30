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
        public string GetWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/forecast?id=524901&appid=f4b61da4bd8cbd9e4917a2c479fbb04f&q=Tashkent");
                var json = web.DownloadString(url);
                //var newJson = json[2];
                var result = JsonConvert.DeserializeObject<CityTemperatureModel>(json);

                var temp = result.list[0].main.temp.ToString();
                return "ffsa";
            }

        }
    }
}
