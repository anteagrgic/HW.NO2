using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherLibrary
{
    public class BiasedGenerator: IRandomGenerator
    {
        private Random generator;

        public BiasedGenerator(Random generator)
        {
            this.generator = generator;
        }

        public double Generate(double min, double max)
        {
            if (generator.Next(0, 3) != 2)
            {
                return generator.NextDouble() * (((max + min) / 2)-min) + min;
            }
            return generator.NextDouble() * (max - (max - min) / 2) + (max - min) / 2;
        }
    }
}
