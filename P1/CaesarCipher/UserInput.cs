public class UserInput
{
    public string Direction { get; set; }
    public string Message { get; set; }
    public string Shift { get; set; }

    public void GetDirection()
    {
        do
        {
            Direction = InputValidator("char", "\nType 'encode' to encrypt, type 'decode' to decrypt: ").ToLower();
        } while (Direction != "encode" && Direction != "decode");
    }

    public void GetMessage()
    {
        Console.WriteLine("\nType your message: ");
        Message = Console.ReadLine();
    }

    public void GetShift()
    {
        Shift = InputValidator("num", "\nType the shift number: ");
    }


    //Checks user input to ensure that: something is entered; intended input type is entered.
	//Requirements: Please specify wether you are checking for "num" (numbers) or "char" characters
	public string inputValidator (string type, string prompt)
	{
		Console.WriteLine (prompt);
		string input = Console.ReadLine();

		switch(type)
		{
			case "char":
				while (!input.All(char.IsLetter) || String.IsNullOrEmpty(input))
				{
					Console.WriteLine("\nInvalid input, please try again. [only characters are accepted]");
					Console.WriteLine (prompt);
					input = Console.ReadLine ();
				}
				break;

			case "num":
				while (!input.All(char.IsDigit) || String.IsNullOrEmpty(input))
				{
					Console.WriteLine("\nInvalid input, please try again. [only numbers are accepted]");
					Console.WriteLine (prompt);
					input = Console.ReadLine ();
				}
				break;
		}
		return input;
	}
}