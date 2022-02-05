using System;

namespace w3_schools
{
    class Program
    {
	   static void Main(string[] args)
	  	{
          //13. Write a C# program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit.

			    Console.Write("Enter number - ");
			    int number = int.Parse(Console.ReadLine());

			    Console.WriteLine("{0}{1}{2}", number, number, number);
		    	Console.WriteLine("{0} {1}", number, number);
		    	Console.WriteLine("{0} {1}", number, number);
			    Console.WriteLine("{0} {1}", number, number);
			    Console.WriteLine("{0}{1}{2}", number, number, number);
			    Console.WriteLine(" ");

		  	//for triangle 
		    	Console.WriteLine("  {0} ", number);
		    	Console.WriteLine(" {0} {1} ", number, number);
		    	Console.WriteLine("{0} {1} {2} ", number, number, number);
	     }
     }
 }
