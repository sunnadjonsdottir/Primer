namespace Verkefni2 
{
    public class WeatherData
    {
        // Properties
        private double _temperature; // Prefixing with an underscore for private fields
        public double Temperature
        {
            get => _temperature; // Expression-bodied getter
            set
            {
                if (Scale == 'C')
                {
                    if (value < -60 || value > 60)
                    {
                        Console.WriteLine("Reading mistake: Temperature in Celsius should be between -60 and 60.");
                    }
                    else
                    {
                        _temperature = value;
                    }
                }
                else if (Scale == 'F')
                {
                    if (value < -76 || value > 140)
                    {
                        Console.WriteLine("Reading mistake: Temperature in Fahrenheit should be between -76 and 140.");
                    }
                    else
                    {
                        _temperature = value;
                    }
                }
            }
        }

        private double _humidity; // Prefix with underscore
        public double Humidity
        {
            get => _humidity;
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Reading mistake: Humidity must be between 0% and 100%.");
                }
                else
                {
                    _humidity = value;
                }
            }
        }

        private char _scale; // Prefix with underscore
        public char Scale
        {
            get => _scale;
            set
            {
                if (value == 'C' || value == 'F')
                {
                    _scale = value;
                }
                else
                {
                    Console.WriteLine("Invalid scale. Please enter 'C' for Celsius or 'F' for Fahrenheit.");
                }
            }
        }

        // Constructor
        public WeatherData(double temperature, double humidity, char scale)
        {
            Scale = scale;      // Set the scale first
            Temperature = temperature; // Then set the temperature to ensure it's validated
            Humidity = humidity;
        }

        // Convert the temperature between Celsius and Fahrenheit
        public void Convert()
        {
            if (Scale == 'C')
            {
                // Convert from Celsius to Fahrenheit
                _temperature = (_temperature * 9 / 5) + 32;
                Scale = 'F';
                Console.WriteLine($"Temperature converted to Fahrenheit: {_temperature}°F");
            }
            else if (Scale == 'F')
            {
                // Convert from Fahrenheit to Celsius
                _temperature = (_temperature - 32) * 5 / 9;
                Scale = 'C';
                Console.WriteLine($"Temperature converted to Celsius: {_temperature}°C");
            }
        }

        // Display the current weather data
        public void DisplayWeather()
        {
            Console.WriteLine($"Temperature: {Temperature}°{Scale}");
            Console.WriteLine($"Humidity: {Humidity}%");
        }
    }

    class Program
    {
        static void Main()
        {
            // Test the WeatherData class
            WeatherData weather = new WeatherData(25, 50, 'C'); // 25°C, 50% Humidity
            weather.DisplayWeather();

            weather.Convert(); // Convert to Fahrenheit
            weather.DisplayWeather();

            // Test with incorrect temperature
            weather.Temperature = -100; // Should print an error

            // Test humidity out of range
            weather.Humidity = 150; // Should print an error

            // Set a valid temperature in Fahrenheit and convert back
            weather.Temperature = 100; // 100°F
            weather.Convert(); // Convert back to Celsius
            weather.DisplayWeather();
        }
    }
}