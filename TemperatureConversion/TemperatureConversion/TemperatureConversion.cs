using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatureconversion
{
    public class TemperatureCel
    {
        double Celsius;
        double fahrenheit;
        public void TemCel()
        {
            Console.WriteLine("Enter a Input to convert in Fahrenheit");
            double Celsius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Celsius: " + Celsius);
            fahrenheit = (Celsius * 9) / 5 + 32;
            Console.WriteLine("Fahrenheit: " + fahrenheit);
            Console.ReadLine();

        }
        public void CelTemp()
        {

            Console.WriteLine("Enter a Input to convert in Celsius");
            double Celsius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("FeHrenheit: " + fahrenheit);
            Celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Celsius: " + Celsius);
            Console.ReadLine();
        }
    }
}
