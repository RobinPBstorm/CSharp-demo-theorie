using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_structure_slide.models
{
    public struct Celsius
    {
        public double Temperature;

        public Celsius(double temperature)
        {
            Temperature = temperature;
        }

        public Fahrenheit ToFahrenheit()
        {
            //(32 °F − 32) × 5 / 9

            return new Fahrenheit((Temperature * 9 / 5) + 32);
        }

        public string AffichageCelsius()
        {
            return $"{Temperature} °C";
        }
    }
}
