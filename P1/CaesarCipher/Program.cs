class Program
{
	static void Main (string[] args )
	{

        CaesarCipher Cipher = new CaesarCipher(); 

        // Prints ASCII art and program description
        CaesarUI.printUI();


        bool run_program = true;

        // Runs program until user quits
        while (run_program)
        {
            // Gets user inputs
            string direction = UserInput.GetDirection
            string message = UserInput.GetMessage
            string shift = UserInput.GetShift

            // Encrypts user inputs
            Cipher.encryptor(direction, message, shift);

            //Prompts user to decide wether they would like to restart or exit program
            run_program = Cipher.restartProgram();

        }
        Console.WriteLine( "\nGoodBye!\n" );
	}
}