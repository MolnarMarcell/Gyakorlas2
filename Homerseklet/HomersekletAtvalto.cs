using System;
using System.Collections.Generic;
using System.Text;

namespace Homerseklet
{
    internal class HomersekletAtvalto
    {
        public double Celsius;

        public double ToFahrenheit()
        {
            return Celsius * 9/5 + 32;
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            return celsius * 9/5 + 32;
        }

    }
}
