using System;

namespace w3_schools
{
    class Program
    {
		  static void Main(string[] args)
		  {
         //12. Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it two times: Use Console. Write and then use {0}.

		  	Console.Write("Enter a number - ");
			  int input = int.Parse(Console.ReadLine());

			  Console.WriteLine("{0} {1} {2} {3} ", input, input, input, input);
			  Console.WriteLine("{0}{1}{2}{3} ", input, input, input, input);
      
     }
   }
}
