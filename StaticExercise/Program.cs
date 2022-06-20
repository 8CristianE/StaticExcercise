using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("What temperature in Fahrenhiet do you want to convert to Celsius");
            double ftemp = Convert.ToDouble(Console.ReadLine());
            double ctemp = TempConverter.FahrenheitToCelsius(ftemp);
            Console.WriteLine($"{ctemp} degrees Celsuius");
            ;
            Console.WriteLine("**************************");

            Console.WriteLine("What temperature in Celsuis do you want to convert to Fahrenhiet");
            double Ctemp = Convert.ToDouble(Console.ReadLine());
            double Ftemp = TempConverter.FahrenheitToCelsius(Ctemp);
            Console.WriteLine($"{Ftemp} degrees Fahrenhiet");


        }

    }
}

