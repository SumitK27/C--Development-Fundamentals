using System;

namespace MyUtilities
{
    class WeatherUtilities
    {
        static float FahrenheitToCelsius(float temperatureFahrenheit)
        {
            return (temperatureFahrenheit - 32) / 1.8f;
        }

        static float CelsiusToFahrenheit(float temperatureCelsius)
        {
            return (float)(temperatureCelsius * 1.8f + 32);
        }

        static float ComfortIndex(float temperatureFahrenheit, float humidityPercent) => (float)((temperatureFahrenheit + humidityPercent) / 4);

        public static void Report(string location, float temperatureCelsius, float humidity)
        {
            var temperatureFahrenheit = CelsiusToFahrenheit(temperatureCelsius);
            Console.WriteLine($"Comfort Index of: {location}: {ComfortIndex(temperatureFahrenheit, humidity)}");
        }
    }
}
