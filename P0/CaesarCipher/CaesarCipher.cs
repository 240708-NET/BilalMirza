class CaesarCipher()
{


//Fields
	char [] alphabet = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'a', 'b', 'c', 'd', 'e',  'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'];


	string direction = inputValidator("char", "Type 'encode' to encrypt, type 'decode' to decrypt: ")
	string message = inputValidator("char", "Type your message: ")
	//message = message.ToLower()
	int shift = inputValidator("num", "Type the shift number: ")

/*
 public string encryptor(string cipher_direction, string start_text, int shift_amount)
 {
	end_text = "";
	foreach (char c in start_text)
	{
		position = alphabet.index(c)
		if (cipher_direction == "encode")
		{
			new_position = position + shift_amount
		}
		else if (cipher_direction == "decode")
		{
			new_position = position - shift_amount
		}
		else
		{
			//reprompt
		}
		new_position = position - shift_amount
		end_text += alphabet[new_position]
	}
	return end _text;
 }

 Console.WriteLine(f"Here's the {direction}d result: {end_text}");


 */

 /* 
 def caesar(cipher_direction, start_text, shift_amount):
  end_text = ""
  for letter in start_text:
    position = alphabet.index(letter)
    if cipher_direction == "encode":
      new_position = position + shift_amount
    elif cipher_direction == "decode":
      new_position = position - shift_amount
    end_text += alphabet[new_position]
  print(f"Here's the {direction}d result: {end_text}")
*/


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

	//This method checks user input to ensure that: something is entered; intended input type is entered.
	public string inputValidator (string type, string prompt)
	{
		Console.WriteLine (prompt);
		string input = Console.ReadLine ();

		if (type == "char")
			while (!input.All(char.IsLetter) || String.IsNullOrEmpty(input))
			{
				Console.WriteLine("Invalid input, please try again. [only characters are accepted]");
				Console.WriteLine (prompt);
				input = Console.ReadLine ();
			}
		else if (type == "num")
		{
			while (!input.All(char.IsDigit) || String.IsNullOrEmpty(input))
			{
			Console.WriteLine("Invalid input, please try again. [only numbers are accepted]");
			Console.WriteLine (prompt);
			input = Console.ReadLine ();
			}
		}
		return input;
	}


}
