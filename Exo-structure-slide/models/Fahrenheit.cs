using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_structure_slide.models
{
    public struct Fahrenheit
    {
        public double Temperature;

        public Fahrenheit(double temperature)
        {
            Temperature = temperature;
        }

        public Celsius ToCelsius()
        {
            //(32 °F − 32) × 5 / 9

            return new Celsius((Temperature - 32) * 5 / 9 );
        }


        public string AffichageFahrenheit()
        {
            return $"{Temperature} °F";
        }
    }
}
