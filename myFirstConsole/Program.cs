// See https://aka.ms/new-console-template for more information

public class Program
{

	public static void Main(string[] args) //ENTRYPOINT - Main Method- start point --
	{
	
		/*
		Method - a block of code/ group of code with a labeled functionality
		Methods make a code readable for developers, and reusable - instead of writing the same line 
		over and over, just "call" the method.
		*/

		Console.WriteLine("Hello, World!");

		/*Object oriented programming - 
			a paradigm of programming that bundles of data and values and behvaior to create an 
			object. Application funcitonality is dependent on relationships between objects.

		Variables - Data Types
			C# is Strongly types - we need to declare what type of data is going to be 
			in each variable
		Compiling - 
			taking the code we've written (in C#) and parsing that code into something the 
			computer can underdtand.
		Interpreted - 
			"reads" the code line-by-line as it is running, and executes the application "on 
			the fly". 
		
			(A compiled application will be faster than an interpreted application).
		*/

		Console.WriteLine("Please enter your name for a personalized greeting: ");
		
		// string type holds Text
		// declaring a variable 
		// <variable type> <name>

		// instantiate a variable
		// <variable> = <value>

		string userName = "Bilal"; //declaration and instantiation
		// userName = "Richard"; //assignment (re-assigning)
		
		userName = Console.ReadLine(); // Console is the object, Readline is the behavior.

		// Console.WriteLine("Welcome to Revature: ");
		// Console.WriteLine(userName);

		// Console.WriteLine("Welcome to Revature: " + userName); //concatenation

		Console.WriteLine("Welcome to Revature: {0}", userName); //Interpolation
		Console.WriteLine( $"Welcome to Revature: {userName}"); //String Formating

		/*
			--Summary of Data Types--
			
			1 0 - binary
			decimal - 5 ==> binary - 0101 (8,4,2,1 or 2^3,2^2,2^1,2^0)
			
			Numeric Data Types
			double, float, long, short, decimal
			Intigers - Whole Numbers

			Boolean (true or false) - 1 or 0

			Char -> Character (single)
			String -> string of Text (words)

			byte and bit (not as common, but they're still there)
		*/

		/*
			--Conditonal statement and control flow--
				if, else if, else
				switch, case
				try, catch, finally (exception handling)
			
			--looping--
				for (specific number of loops)
				do-while (executes once before checking condition)
				while (checkss the condition before executing)
				foreach (iterate through a collection)

		*/
		
		bool? runChoice = null;
		
		if ( runChoice == true )
		{
			Console.WriteLine( "runChoice is true!" );
		}

		else if ( runChoice == false ) 
		{
			Console.WriteLine( "runChoice is false" );
		}

		else
		{
			Concole.WriteLine( "runChoice is undefined/null" );
		}
		
		//Comparison operators ==, >, < , >=, <=, != (the ! - not - operator is very versatile!)

		
		if (5 > 4)
		{
			Console.WriteLine( "Five is greater than four" );
		}
		
		
			
	}
}
