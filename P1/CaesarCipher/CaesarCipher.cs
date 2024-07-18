class CaesarCipher()
{
	//Fields
	char[] alphabet = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz".ToCharArray(); //double alphabet to handle forwards wrapping through alphatebt (test: 'encode' "xyz")

	// encryptor: Handles encryption logic
	// Direction - dictates wether user would like to encode or decode a message
	// Message - Message user would like to encode
	// Shift - the amount a user would like to shift each character in a message.

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
		return Console.WriteLine($"\n -- Here's the {direction}d result: {end_text} --");
	}

	//Prompts user to decide wether to restart program or quit; Returns a boolean to signify continuation/ ending of program.
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
