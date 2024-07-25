using System;
using Models;
using Repository;

namespace Logic;

class CaesarCipher : ICipher
{
    public int CipherID { get; set; }
    public string Message { get; set; }
    public int Shift { get; set; }
    public DateTime DateCreated { get; set; }

	//Fields
	private readonly char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

	// Encrypts the input text with the given shift
	public string Encrypt()
	{
		return ProcessText(Message, Shift);
	}

	// Decrypts the input text with the given shift
	public string Decrypt()
	{
		return ProcessText(Message, -Shift);
	}

    // Process the text for encryption or decryption
	private string ProcessText(string text, int shift)
	{
		string result = "";
		int alphabetLength = alphabet.Length;

		foreach (char c in text.ToLower()) // ToLower to handle uppercase input
		{
			int position = Array.IndexOf(alphabet, c);

			if (position != -1)
			{
				int new_position = (position + shift + alphabetLength) % alphabetLength;
				result += alphabet[new_position];
			}
			else
			{
				result += c; // Preserve spaces and other non-letter characters
			}
		}
		return result;
	}
}