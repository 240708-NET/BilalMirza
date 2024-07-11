class Program
{
	static void Main (string[] args )
	{

        Encryptor Encrypt = new Encryptor(); 

        //References variable containing Logo Design from the 'CaesarArt' class
		Console.WriteLine ($"{CaesarArt.logo}");
        string input = Encrypt.inputVal("Type 'encode' to encrypt, type 'decode' to decrypt: ");




        Console.WriteLine( "GoodBye" );
	}
}