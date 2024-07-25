namespace Utilities;

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


using System;
using Logic;
using Repository;
using Microsoft.Extensions.DependencyInjection;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddDbContext<CipherContext>()
                .AddScoped<ICipherRepository, CipherRepository>()
                .AddScoped<CaesarCipherService>()
                .BuildServiceProvider();

            var cipherService = serviceProvider.GetService<CaesarCipherService>();

            while (true)
            {
                Console.WriteLine("Enter 1 to Encrypt, 2 to Decrypt, 3 to View All Ciphers, 0 to Exit:");
                var choice = Console.ReadLine();

                if (choice == "0") break;

                Console.WriteLine("Enter your message:");
                var message = Console.ReadLine();

                Console.WriteLine("Enter your shift:");
                var shift = int.Parse(Console.ReadLine());

                if (choice == "1")
                {
                    var encrypted = cipherService.Encrypt(message, shift);
                    Console.WriteLine($"Encrypted Message: {encrypted}");
                    cipherService.SaveCipher(message, shift);
                }
                else if (choice == "2")
                {
                    var decrypted = cipherService.Decrypt(message, shift);
                    Console.WriteLine($"Decrypted Message: {decrypted}");
                }
                else if (choice == "3")
                {
                    var ciphers = cipherService.GetAllCiphers();
                    foreach (var cipher in ciphers)
                    {
                        Console.WriteLine($"ID: {cipher.CipherID}, Message: {cipher.Message}, Shift: {cipher.Shift}, Date Created: {cipher.DateCreated}");
                    }
                }
            }
        }
    }
}


    public static void printUI()
    {
    Console.Write ($"{logo} + {description}");
    }
}