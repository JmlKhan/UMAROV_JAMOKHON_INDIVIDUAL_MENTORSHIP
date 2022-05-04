using DAL.Model;
using System.Net.Http.Json;

namespace DAL
{
    public class WeatherApi
    {

        public async Task<CityTemperatureModel> GetWeatherAsync(string cityName)
        {
            using (var web = new HttpClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/forecast?id=524901&appid=f4b61da4bd8cbd9e4917a2c479fbb04f&q={0}", cityName);
                var response = await web.GetAsync(url);
                var result = await response.Content.ReadFromJsonAsync<CityTemperatureModel>();

                return result!;
            }

        }
    }
}
