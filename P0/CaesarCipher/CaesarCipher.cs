class CaesarCipher()
{


//Fields
	char [] alphabet = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'a', 'b', 'c', 'd', 'e',  'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'];


 	public string encryptor(string cipher_direction, string start_text, int shift_amount)
 	{
		string end_text = "";
		int position;
		int new_position;

		if (cipher_direction == "decode")
			{
				shift_amount *= -1;
			}

		foreach (char c in start_text)
		{
			position = Array.IndexOf(alphabet, c);
			new_position = position + shift_amount;
			end_text += alphabet[new_position];
		}
		return end_text;
	}

	//Checks user input to ensure that: something is entered; intended input type is entered.
	//Requirements: Please specify wether you are checking for "num" (numbers) or "char" characters
	public string inputValidator (string type, string prompt)
	{
		Console.WriteLine (prompt);
		string input = Console.ReadLine ();

		if (type == "char")
			while (!input.All(char.IsLetter) || String.IsNullOrEmpty(input))
			{
				Console.WriteLine("\nInvalid input, please try again. [only characters are accepted]");
				Console.WriteLine (prompt);
				input = Console.ReadLine ();
			}
		else if (type == "num")
		{
			while (!input.All(char.IsDigit) || String.IsNullOrEmpty(input))
			{
			Console.WriteLine("\nInvalid input, please try again. [only numbers are accepted]");
			Console.WriteLine (prompt);
			input = Console.ReadLine ();
			}
		}
		return input;
	}

	//Prompts user to decide wether they would like to restart program or quit.
	public bool restartProgram ()
	{
		string choice = "";

		while (choice != "yes" && choice != "no")
		{
			Console.WriteLine ("\nType 'yes' if you want to go again. Otherwise type 'no'.");
			choice = Console.ReadLine().ToLower();
		}

		if ( choice == "no")
        {
            return false;
        }
		else
		{
			return true;
		}
	}


}
