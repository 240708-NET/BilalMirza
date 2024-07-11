class Encryptor()
{

//


//Fields
//Variables
	char [] alphabet = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'a', 'b', 'c', 'd', 'e',  'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'];
	string prompt = "Type 'encode' to encrypt, type 'decode' to decrypt: ";
 	


	public string inputVal (string prompt)
	{
		string input;

		Console.WriteLine (prompt);
		input = Console.ReadLine ().ToLower ();
		while (input != "encode" || input != "decode")
		{
			Console.WriteLine("Invalid input.");
			Console.WriteLine (prompt);
			input = Console.ReadLine ();
		}
		return input;
	}


/*
	Console.WriteLine("Type 'encode' to encrypt, type 'decode' to decrypt: ")


	Console.WriteLine("Type your message: ");
	string message = console.ReadLine();
	message = message.ToLower()

	Console.WriteLine("Type the shift number: ");
	string shift = Console.ReadLine();

	void caeser(direction, text, shift)
	{
	




	}

*/


}
