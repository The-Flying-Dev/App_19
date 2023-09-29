namespace TemperatureConverter;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Temperature Converter");
        Console.WriteLine(
            "Press 'c' to convert from Celcius to Farenheit or 'f' to convert from Farenheit to Celcius."
        );
        string choice = Console.ReadLine();

        if (choice == "c")
        {
            Console.WriteLine("Enter a temperature in Celcius.");
            float celcius = float.Parse(Console.ReadLine()); // Using Parse to convert into a float

            float farenheit = celcius * 1.8f + 32f; // f as the suffix, used for floats
            
            Console.WriteLine("The temperature in Farenheit is " + farenheit);
        }
        else
        {
            Console.WriteLine("Enter a temperature in Farenheit.");
            float farenheit = float.Parse(Console.ReadLine());

            /* Since divide takes precedence over Subtraction due to "Operator Precedence"
              Brackets need to be placed around the Subtraction to make it happen first 
            */
            float celcius = (farenheit - 32f) / 1.8f; // f as the suffix, used for floats
            
            Console.WriteLine("The temperature in Celcius is " + celcius);
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadLine();
    }
}