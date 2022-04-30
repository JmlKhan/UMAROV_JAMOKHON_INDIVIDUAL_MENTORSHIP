using BL.Services;

string cityName;

Console.WriteLine("Enter city name: \n");
cityName = Console.ReadLine();

var result = new Print();
result.Response(cityName);
