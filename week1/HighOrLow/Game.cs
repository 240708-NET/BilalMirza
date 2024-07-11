class Game
{
	
	// Computer Should choose random number
	// User should be able to submit a guess
	// if guess is too high then computer informs user
	// if guess is too low then computer informs user
	// a user wins when they guess the target number
	// a user should keep guessing until they guess the correct target number
	
	// Fields
    Random rand = new Random();
	int targetNumber;
	private int guessNumber = -1; 
	private int roundCount = 0;
	public string guessString {get; set;} = ""; // auto-property

    //Methods

	//getters and setters - short methods that allow you to "get" (retrieve), or "set" (assign) a value to a field. (protects your values)
	//(C# will automatically write a getter and setter for us) - [Field] {get; set;}

	public int get_guessNumber()
	{
		return this.guessNumber;
	}

	public void set_guessNumber (int _guessNumber)
	{
		if (_guessNumber > 0)
			this.guessNumber = _guessNumber;
	}

    // Method Signiture structure
	// [Access Mod] [Modifier] [Return Type] [Method Name] (Method Parameters)
    // Class : Object :: Blueprint : Building

    /* Access Modifiers: public (anything can access), private (only accessible from the same object), 
    protected (only accessible from the class/ object or its child/sub/inherited class), internal 
    (can only be accessed from within the same compiled assembly)
    */

    /* Modifier: (definition) Non-access modifiers in programming, specifically in languages like Java and 
    C#, are keywords that provide additional information about the characteristics of a class, method, or 
    variable, without affecting their accessibility.

    ReadOnly: this thing can only be modified in the constructor of the class
    Static: this thing (method or field) belongs to the Class, not to the Object (it is shared among all 
    instances of the class)
    */

    // Constructor: 

	public Game()
	{
		targetNumber = rand.Next(11);
	}

    public int PlayGame()
    {
		roundCount = 0;

        do {
		//roundCount = roundCount + 1;
		//roundCount += 1;
		roundCount++;

		Console.Write( "Please enter a guess between -1 and 11: " );
		guessString = Console.ReadLine();
	
		guessNumber = Int32.Parse( guessString );
	
		if( guessNumber == targetNumber )
		{
			Console.WriteLine( "You guessed correct, Congratulations!");
		}
	
		else if( guessNumber > targetNumber )
		{
			Console.WriteLine( "Oops, too high!");
		}
	
		else
		{
			Console.WriteLine( "Oops, too low!" );
		}
	
	    } while ( guessNumber != targetNumber );

		return roundCount;
    }

	
}
