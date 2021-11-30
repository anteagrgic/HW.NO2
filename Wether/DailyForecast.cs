using System;
using System.Collections.Generic;
using System.Text;


namespace WeatherLibrary
{
    public class DailyForecast
    {
        private DateTime dateOfTheDay;//već gleda kao objekt po deafoltu jer je to tip podatka
        private Weather weatherOfTheDay;

        public DailyForecast(DateTime dateOfTheDay, Weather weatherOfTheDay)
        {
            this.dateOfTheDay = dateOfTheDay;
            this.weatherOfTheDay = weatherOfTheDay;
        }

        public Weather GetWeather()
        {
            return weatherOfTheDay ;
        }


        public string GetAsString()
        {
            return dateOfTheDay.ToString("dd/MM/yyyy hh:mm:ss") + " " + weatherOfTheDay.GetAsString();
        }

        public static bool operator <(DailyForecast a,DailyForecast b)
        {

            return (a.weatherOfTheDay.GetTemperature()<b.weatherOfTheDay.GetTemperature());
        }

        public static bool operator >(DailyForecast a, DailyForecast b)
        {

            return (a.weatherOfTheDay.GetTemperature() > b.weatherOfTheDay.GetTemperature());
        }


    }

}
