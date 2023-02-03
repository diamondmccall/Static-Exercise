namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(68);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(20);
            {
                Console.WriteLine($"Celsius is {celsius}!");
                Console.WriteLine($"Fahrenheit is {fahrenheit}");
            }
                
        }
    }
}
