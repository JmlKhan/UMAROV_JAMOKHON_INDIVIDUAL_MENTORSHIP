namespace DAL
{
    public class Api
    {
        public  Task<string> GetResult()
        {
            HttpClient client = new HttpClient();
            var responseTask = client.GetAsync("http://api.openweathermap.org/data/2.5/forecast?id=524901&appid=f4b61da4bd8cbd9e4917a2c479fbb04f&q=Seoul");
            
            responseTask.Wait();
            if (responseTask.IsCompleted)
            {
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var message = result.Content.ReadAsStringAsync();
                    message.Wait();
                    return message;
                }
            }
            return null!;
        } 
        
    }
}