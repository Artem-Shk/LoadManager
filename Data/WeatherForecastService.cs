namespace LoadManager.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            List<WeatherForecast> Weathers = new List<WeatherForecast>();
            foreach(var item in Enumerable.Range(1,5))
            {
                Weathers.Add(new WeatherForecast()
                {
                    Date = startDate.AddDays(item),
                    TemperatureC = Random.Shared.Next(-20,55),
                    Summary= Summaries[Random.Shared.Next(Summaries.Length)]

                });
            }
            var a = Task.FromResult(Weathers.ToArray());
            return a;
            
        }

        //HACK: это тоже самое что и сверху 
        //return Task.FromResult(Enumerable.Range(1, 5).Select(index =>
        //{
        //    return new WeatherForecast
        //    {
        //        Date = startDate.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    };
        //}).ToArray());
    }
}