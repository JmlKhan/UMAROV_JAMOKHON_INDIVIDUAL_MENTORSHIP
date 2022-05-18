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

var ts = new TimeSpan(4, 30, 0);
Console.WriteLine(ts.Subtract(new TimeSpan(0,15,0)));

