using BL.Services;

string cityName;

Console.WriteLine("Enter city name: \n");
cityName = Console.ReadLine();

if (cityName.Length == 0)
{
    Console.WriteLine("enter city name");
}
else
{
    var result = new Print();
    await result.Response(cityName);
}


