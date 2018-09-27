using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ilmapp.Core
{
   public class Core
    {
        public static async Task<Weather> GetWeather(string zipCode)
        {

            string apikey = "1dad50e251b03e9137b8b650a95bc9ff";
            string queryString = "http://api.openweathermap.org/data/2.5/weather?q=Tallinn";

            dynamic results = await DataService.GetDataFromService(queryString).ConfigureAwait(false);
            var weather = new Weather();
            weather.Temprature = (string)results["main"]["temp"] + " C";
            return weather;
        }
    }
}
