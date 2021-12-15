using System;

namespace WeatherLibrary
{
    public class Weather
    {
        private double temperature;
        private double humidity;
        private double windSpeed;

        public Weather(double temperature, double humidity, double windSpeed)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.windSpeed = windSpeed;
            
        }

        

        public Weather() { }

        public string GetAsString()
        {
            return $"T={temperature}°C W={windSpeed}km/h H={humidity}%";
        }
        public double GetTemperature()
        {
            return temperature;
        }

        public void SetTemperature(double temperature)
        {
            this.temperature = temperature;
        }
        public double GetHumidity()
        {
            return humidity;
        }

        public void SetHumidity(double humidity)
        {
            this.humidity = humidity;
        }
        public double GetWindSpeed()
        {
            return windSpeed;
        }

        public void SetWindSpeed(double windSpeed)
        {
            this.windSpeed = windSpeed;
        }

        public double CalculateFeelsLikeTemperature()
        {
            double formula;

            double c1 = -8.78469475556;
            double c2 = 1.61139411;
            double c3 = 2.33854883889;
            double c4 = -0.14611605;
            double c5 = -0.012308094;
            double c6 = -0.0164248277778;
            double c7 = 0.002211732;
            double c8 = 0.00072546;
            double c9 = -0.000003582;

            formula = c1 + c2 * temperature + c3 * humidity + c4 * humidity * temperature + c5 * Math.Pow(temperature, 2) + c6 * Math.Pow(humidity, 2) + c7 * Math.Pow(temperature, 2) * humidity + c8 * temperature * Math.Pow(humidity, 2) + c9 * Math.Pow(temperature, 2) * Math.Pow(humidity, 2);


            return formula;
        }

        public double CalculateWindChill()
        {
            double formula;
            formula = 13.12 + (0.6215 * temperature) - (11.37 * Math.Pow(windSpeed, 0.16)) + (0.3965 * temperature * Math.Pow(windSpeed, 0.16));

            if (windSpeed <= 4.8 || temperature >= 10)
            {
                return 0;
            }
            else return formula;
        }






    }
}
