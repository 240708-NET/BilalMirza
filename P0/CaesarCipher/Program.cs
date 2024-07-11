class Program
{
	static void Main (string[] args )
	{

        CaesarCipher Cipher = new CaesarCipher(); 

        //References variable containing Logo Design from the 'CaesarArt' class
		Console.WriteLine ($"{CaesarArt.logo}");
        string input = Cipher.inputValidator("char", "Type 'encode' to encrypt, type 'decode' to decrypt: ");
        int shift = inputValidator("num", "Type the shift number: ")




        Console.WriteLine( "GoodBye" );
	}
}