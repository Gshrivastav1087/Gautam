using System;

class FahrenheittoDegree
{

    static double fahrenheitToCelcius(double Fahrenheit)
    {
        double celciusTemp = ((Fahrenheit - 32)* 5/9);
        return celciusTemp;
    }

   


    static void Main(String[] args)
    {
        Console.Write("Enter the temperature in Fahrenheit: ");
        double fahrenheitTemp = Convert.ToDouble(Console.ReadLine());

        double tempInCelcius = fahrenheitToCelcius(fahrenheitTemp);
        Console.WriteLine("The Temperature in Celcius is: " + tempInCelcius);

    }

}

