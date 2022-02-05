using System;

namespace w3_schools
{
    class Program
    {
		  static void Main(string[] args)
		  {





  //14. Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.

			  Console.Write("Enter degree - ");
			  int degree = int.Parse(Console.ReadLine());

			  double kelvin = degree + 273.15;
			  double fahrenheit = (degree * 9 / 5) + 32;

			  Console.WriteLine("{0} degree celsius is equivalent to {1} Kelvin.", degree, kelvin);
			  Console.WriteLine("{0} degree celsius is equivalent to {1} Fahrenheit", degree, fahrenheit);
      }
    }
 }
