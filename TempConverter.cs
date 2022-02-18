using System;
using System.Collections.Generic;
using System.Text;

namespace StaticKeyWord
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double fTemp)
        {
            var celTemp = (fTemp - 32) * (5.0 / 9.0);
            return celTemp;
        }
        public static double CelsiusToFahrenheit(double cTemp) 
        {
            return ((cTemp * (9.0 / 5.0)) + 32);
        }
         

        

    }
}
