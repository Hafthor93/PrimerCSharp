using System;


class WeatherData
{
    private double temperature;
    private double humidity;
    private char scale;

    public double Temperature
    {
        get { return temperature; }
        set
        {
            if (value < -60 || value > 60)
            {
                Console.WriteLine("Invalid temperature. Must be between -60 and 60 Celsius.");
            }
            else
            {
                temperature = value;
            }
        }
    }

    public double Humidity
    {
        get { return humidity; }
        set
        {
            if (value < 0 || value > 100)
            {
                Console.WriteLine("Invalid humidity. Must be between 0 and 100.");
            }
            else
            {
                humidity = value;
            }
        }
    }

    public char Scale
    {
        get { return scale; }
        set
        {
            if (value == 'C' || value == 'F')
            {
                scale = value;
            }
            else
            {
                Console.WriteLine("Invalid input. Must be 'C' or 'F'.");
            }
        }
    }

    public void Convert()
    {
        if (scale == 'C')
        {
            temperature = temperature * 9 / 5 + 32;
            scale = 'F';
        }
        else if (scale == 'F')
        {
            temperature = (temperature - 32) * 5 / 9;
            scale = 'C';
        }
    }
}

namespace PrimerCSharp {
class Program
{
    static void Main(string[] args)
    {
        WeatherData data = new WeatherData();

        Console.WriteLine("Enter temperature: ");
        data.Temperature = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter humidity: ");
        data.Humidity = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter scale 'C' or 'F': ");
        data.Scale = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Before conversion:");
        Console.WriteLine("Temperature: " + data.Temperature + " " + data.Scale);
        Console.WriteLine("Humidity: " + data.Humidity + "%");

        data.Convert();

        Console.WriteLine("After conversion:");
        Console.WriteLine("Temperature: " + data.Temperature + " " + data.Scale);
        Console.WriteLine("Humidity: " + data.Humidity + "%");
    }
}
}




