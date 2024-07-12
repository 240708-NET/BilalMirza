class Program
{
	static void Main (string[] args )
	{

        CaesarCipher Cipher = new CaesarCipher(); 

        //References variables containing logo design and app decription from the 'CaesarUI' class
		Console.Write ($"{CaesarUI.logo}");
        Console.Write ($"{CaesarUI.description}");

        bool run_program = true;
        string direction;

        //Run program until user quits
        while (run_program)
        {
            do
            {
                direction = Cipher.inputValidator("char", "\nType 'encode' to encrypt, type 'decode' to decrypt: ");
            }
            while (direction != "encode" && direction != "decode");
            
	        string message = Cipher.inputValidator("char", "\nType your message: ");
	        string shift = Cipher.inputValidator("num", "\nType the shift number: ");

            string end_text = Cipher.encryptor(direction, message, shift);

            Console.WriteLine($"\n -- Here's the {direction}d result: {end_text} --");

            //Prompts user to decide wether they would like to restart or exit program
            run_program = Cipher.restartProgram();

        }
        Console.WriteLine( "\nGoodBye!\n" );
	}
}