using System;

namespace w3_schools
{
    class Program
    {
		  static void Main(string[] args)
		  {  
//11. Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20".

			Console.Write("Enter age - ");
			int userAge = int.Parse(Console.ReadLine());

			Console.WriteLine("You look older than {0}", userAge);

      
      }
    }
}
