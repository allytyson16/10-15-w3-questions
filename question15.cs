using System;

namespace w3_schools
{
    class Program
    {
		  static void Main(string[] args)
		  {

    //15. Write a C# program remove specified a character from a non-empty string using index of a character

		    	Console.WriteLine("Hello, Universe, My name is Adelaide and my journey in C# is to arrive as a Game Developer.😁");
		    	string specified = "Hello, Universe, My name is Adelaide and my journey in C# is to arrive as a Game Developer.😁";
			//deleting 17 characters.
   			  String charRemoved = specified.Remove(0, 17);
			    Console.WriteLine(charRemoved);




		  }
  	}
}
