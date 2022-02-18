using System;
using System.Collections.Generic;
using System.Text;

namespace StaticKeyWord
{
    
    class Program 
    { 

        static void Main(string[] args) 
        {
            Console.WriteLine("what is the temperature in F you want to convert?");

            double fahTemp = Convert.ToDouble(Console.ReadLine());
            double convertToCel = TempConverter.FahrenheitToCelsius(fahTemp);

            Console.WriteLine($"That equals {convertToCel} degrees Celsius");
            Console.WriteLine();

            Console.WriteLine("what is the temperature in C you want to convert?");

            double celTemp = Convert.ToDouble(Console.ReadLine());
            double convertToFah = TempConverter.CelsiusToFahrenheit(celTemp);

            Console.WriteLine($"That equals {convertToFah} degrees Fahrenheit");
            Console.WriteLine();


        } 
    }


}    

    
    


