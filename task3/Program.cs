using DAL;

//var newApi = new Api();

//var result = newApi.GetResult();
//result.Wait();
var obj = new WeatherApi();
var result = obj.GetWeather();
Console.WriteLine(result);