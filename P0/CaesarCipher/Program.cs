class Program
{
	static void Main (string[] args )
	{

        CaesarCipher Cipher = new CaesarCipher(); 
        UserInput userInput = new UserInput();

        // Prints ASCII art and program description
        CaesarUI.printUI();


        bool run_program = true;

        // Runs program until user quits
        while (run_program)
        {
            // Gets user inputs
            userInput.GetDirection();
            userInput.GetMessage();
            userInput.GetShift();

            // Encrypts user inputs
            string result = Cipher.encryptor(userInput.Direction, userInput.Message, userInput.Shift);
            Console.WriteLine(result);

            //Prompts user to decide wether they would like to restart or exit program
            run_program = Cipher.restartProgram();

        }
        Console.WriteLine( "\nGoodBye!\n" );
	}
}