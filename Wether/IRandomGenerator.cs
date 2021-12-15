using System;
using System.Collections.Generic;
using System.Text;


namespace WeatherLibrary
{
    public interface IRandomGenerator
    {
        double Generate(double min, double max);


    }
}
