using System;

namespace API
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }
        public int TempC { get; set; }
        public int TempF => 32 + (int)(TempC / 0.5556);
        public string Summary { get; set; }
    }
}