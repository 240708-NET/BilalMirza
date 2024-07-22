public class CaesarUI ()
{

        public static string logo = @"
    ┏━━━┓━━━━━━━━━━━━━━━━━━━━━━━━━┏━━━┓━━━━━━┏┓━━━━━━━━━
    ┃┏━┓┃━━━━━━━━━━━━━━━━━━━━━━━━━┃┏━┓┃━━━━━━┃┃━━━━━━━━━
    ┃┃━┗┛┏━━┓━┏━━┓┏━━┓┏━━┓━┏━┓━━━━┃┃━┗┛┏┓┏━━┓┃┗━┓┏━━┓┏━┓
    ┃┃━┏┓┗━┓┃━┃┏┓┃┃━━┫┗━┓┃━┃┏┛━━━━┃┃━┏┓┣┫┃┏┓┃┃┏┓┃┃┏┓┃┃┏┛
    ┃┗━┛┃┃┗┛┗┓┃┃━┫┣━━┃┃┗┛┗┓┃┃━━━━━┃┗━┛┃┃┃┃┗┛┃┃┃┃┃┃┃━┫┃┃━
    ┗━━━┛┗━━━┛┗━━┛┗━━┛┗━━━┛┗┛━━━━━┗━━━┛┗┛┃┏━┛┗┛┗┛┗━━┛┗┛━
    ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┃┃━━━━━━━━━━━━━
    ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┗┛━━━━━━━━━━━━━
    " ;

        public static string description = @"
    ------------------------------------------------------------------------------
    Welcome to the Caesar Cipher Program!

    Easily encrypt and decrypt your messages using the classic Caesar cipher. 
    Simply enter your message and choose a shift value, and this program will shift 
    each letter in the alphabet to create your coded message. Perfect for learning 
    about encryption or sending secret messages to friends. Enjoy encrypting!
    ------------------------------------------------------------------------------
    " ;

    public static void printUI()
    {
		Console.Write ($"{logo} + {description}");
    }

}