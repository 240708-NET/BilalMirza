class Program
{
	static void Main (string[] args )
	{

        CaesarCipher Cipher = new CaesarCipher(); 

        //References variables containing logo design and app decription from the 'CaesarUI' class
		Console.Write ($"{CaesarUI.logo}");
        Console.Write ($"{CaesarUI.description}");

        bool run_program = true;

        //Run program until user quits
        while (run_program)
        {
            string direction = Cipher.inputValidator("char", "\nType 'encode' to encrypt, type 'decode' to decrypt: ");
	        string message = Cipher.inputValidator("char", "\nType your message: ");
	        string shift = Cipher.inputValidator("num", "\nType the shift number: ");
            int shiftNum = Int32.Parse(shift) % 26;

            string end_text = Cipher.encryptor(direction, message, shiftNum);

            Console.WriteLine($"\nHere's the {direction}d result: {end_text}");

            //Prompts user to decide wether they would like to restart or exit program
            run_program = Cipher.restartProgram();

        }
        Console.WriteLine( "\nGoodBye!" );
	}
}