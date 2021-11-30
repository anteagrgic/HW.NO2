using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace WeatherLibrary
{
    public class ForecastUtilities
    {   
        
        public ForecastUtilities() {}
        public static DailyForecast Parse(string parameter)
        {
            string[] parameters = parameter.Split(',');

            DateTime dateOfTheDay = DateTime.ParseExact(parameters[0], "dd/MM/yyyy" + " " + "HH:mm:ss", CultureInfo.InvariantCulture);

            Weather weatherOfTheDay = new Weather(double.Parse(parameters[1], System.Globalization.CultureInfo.InvariantCulture), double.Parse(parameters[3], System.Globalization.CultureInfo.InvariantCulture), double.Parse(parameters[3], System.Globalization.CultureInfo.InvariantCulture));

            DailyForecast forecast = new DailyForecast(dateOfTheDay, weatherOfTheDay);
            
            return forecast;
        }



    }
}






