using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherLibrary
{
    public class UniformGenerator: IRandomGenerator
    {
        private Random generator;

        public UniformGenerator(Random generator)
        {
            this.generator = generator;
        }

        public double Generate(double min, double max)
        {
            return generator.NextDouble() * (max - min)+min;
        }
    }
}
