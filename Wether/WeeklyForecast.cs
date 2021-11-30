using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherLibrary
{
    public class WeeklyForecast
    {
        private DailyForecast[] dailyForecasts;

        public WeeklyForecast(DailyForecast[] dailyForecasts)
        {
            this.dailyForecasts = dailyForecasts;
        }

        public string GetAsString()
        {
            int i;
            int n = 7;
            string weekForecasts = "";

            for (i = 0; i < n; i++)
            {
                weekForecasts += dailyForecasts[i].GetAsString() + "\n";
            }

            return weekForecasts;
        }

        public double GetMaxTemperature()
        {
            DailyForecast temp = dailyForecasts[0];
            int n = 7;
            int i;
            for (i = 0; i < n; i++)
            {
                if (dailyForecasts[i] > temp)
                {
                    temp = dailyForecasts[i];
                }
            }

            return temp.GetWeather().GetTemperature();


        }

        public DailyForecast this[int i] { get { return dailyForecasts[i]; } private set { this.dailyForecasts[i] = value; }  }

    }
    }
