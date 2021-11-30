using System;
using WeatherLibrary;
using System.IO;

namespace OOP_ZADAĆA2
{
    class Program
    {
        private static void RunDemoForHW2()
        {
            DateTime monday = new DateTime(2021, 11, 8);
            Weather mondayWeather = new Weather(6.17, 56.13, 4.9);
            DailyForecast mondayForecast = new DailyForecast(monday, mondayWeather);
            Console.WriteLine(monday.ToString());
            Console.WriteLine(mondayWeather.GetAsString());
            Console.WriteLine(mondayForecast.GetAsString());

            // Assume a valid input file (correct format).
            // Assume that the number of rows in the text file is always 7. 
            string fileName = "weatherForecast.txt";
            if (File.Exists(fileName) == false)
            {
                Console.WriteLine("The required file does not exist. Please create it, or change the path.");
                return;
            }

            string[] dailyWeatherInputs = File.ReadAllLines(fileName);
            DailyForecast[] dailyForecasts = new DailyForecast[dailyWeatherInputs.Length];//daylyForecast mi je polje objekata daily dakle imam polje objekata
            for (int i = 0; i < dailyForecasts.Length; i++)
            {
                dailyForecasts[i] = ForecastUtilities.Parse(dailyWeatherInputs[i]);//saznajem da mi ide iz sringa u daily, utilities vraća objekt klase daily, a ja primam string zato se i fja zove parse da bi pretvorila string u objejt klase daily iz utilitesa
            }//parse predstavlja neku pretvorbu, convert prebacuje npr u int i double ili string 
            WeeklyForecast weeklyForecast = new WeeklyForecast(dailyForecasts);
            Console.WriteLine(weeklyForecast.GetAsString());
            Console.WriteLine("Maximal weekly temperature:");
            Console.WriteLine(weeklyForecast.GetMaxTemperature());
            Console.WriteLine(weeklyForecast[0].GetAsString());
        }
        static void Main(string[] args)
        {
            RunDemoForHW2();
        }
    }
}
