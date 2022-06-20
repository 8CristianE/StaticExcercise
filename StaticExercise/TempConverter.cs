using System;

namespace StaticExercise
{
	public static class TempConverter
	{
		public static double FahrenheitToCelsius(double fnum)
		{
			var Celsius = (fnum - 32) * 5 / 9;
			return Celsius;
		}

		public static double CelsiusToFahrenheit(double cnum)
        {

			return (cnum * (9 / 5)) + 32;
        }

        
    }
}


