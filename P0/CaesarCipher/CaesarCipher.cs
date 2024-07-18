class CaesarCipher()
{
	//Fields
	char[] alphabet = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz".ToCharArray(); //double alphabet to handle forwards wrapping through alphatebt (test: 'encode' "xyz")

	// Handles encryption of user input.
 	public string encryptor(string cipher_direction, string start_text, string shift_amount)
 	{
		string end_text = "";
		int position;
		int new_position;
		int shiftNum = Int32.Parse(shift_amount) % 26; //Mod 26 to keep value in the bounds of the 'alphabet' array

		if (cipher_direction == "decode")
		{
			shiftNum *= -1;
		}

		foreach (char c in start_text.ToLower()) //To.Lower to handle uppercase input
		{
			position = Array.IndexOf(alphabet, c);

			if (position != -1)
            {
				new_position = position + shiftNum;

				if (new_position < 0) //Handles wrapping backwards during decoding (test: 'decode' "abc")
				{
					new_position += 26; //alphabet length
				}

				end_text += alphabet[new_position];
			}
			else
			{
				end_text += c; // Preserve spaces and other non-letter characters
			}
		}
		return end_text;
	}

	// Checks user input to ensure that: Something is entered; intended input type is entered.
	// Requirements: Please specify wether you are checking for "num" (numbers) or "char" characters
	public string inputValidator (string type, string prompt)
	{
		Console.WriteLine (prompt);
		string input = Console.ReadLine();

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

	//Prompts user to decide wether to restart program or quit; Returns a boolean to signify continuation/ending of program.
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
