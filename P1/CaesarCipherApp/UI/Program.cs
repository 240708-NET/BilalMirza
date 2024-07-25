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

            Console.WriteLine(@"
                    ┏━━━┓━━━━━━━━━━━━━━━━━━━━━━━━━┏━━━┓━━━━━━┏┓━━━━━━━━━
                    ┃┏━┓┃━━━━━━━━━━━━━━━━━━━━━━━━━┃┏━┓┃━━━━━━┃┃━━━━━━━━━
                    ┃┃━┗┛┏━━┓━┏━━┓┏━━┓┏━━┓━┏━┓━━━━┃┃━┗┛┏┓┏━━┓┃┗━┓┏━━┓┏━┓
                    ┃┃━┏┓┗━┓┃━┃┏┓┃┃━━┫┗━┓┃━┃┏┛━━━━┃┃━┏┓┣┫┃┏┓┃┃┏┓┃┃┏┓┃┃┏┛
                    ┃┗━┛┃┃┗┛┗┓┃┃━┫┣━━┃┃┗┛┗┓┃┃━━━━━┃┗━┛┃┃┃┃┗┛┃┃┃┃┃┃┃━┫┃┃━
                    ┗━━━┛┗━━━┛┗━━┛┗━━┛┗━━━┛┗┛━━━━━┗━━━┛┗┛┃┏━┛┗┛┗┛┗━━┛┗┛━
                    ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┃┃━━━━━━━━━━━━━
                    ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┗┛━━━━━━━━━━━━━

            ------------------------------------------------------------------------------
            Welcome to the Caesar Cipher Program!

            Easily encrypt and decrypt your messages using the classic Caesar cipher. 
            Simply enter your message and choose a shift value, and this program will shift 
            each letter in the alphabet to create your coded message. Perfect for learning 
            about encryption or sending secret messages to friends. Enjoy encrypting!
            ------------------------------------------------------------------------------

            " );

            var message = "";
            var shift = 0;

            while (true)
            {
                Console.WriteLine("Enter 1 to Encrypt, 2 to Decrypt, 3 to View All Ciphers, 0 to Exit:");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        return;
                    case "1":
                        Console.WriteLine("\nEnter your message:");
                        message = Console.ReadLine();

                        Console.WriteLine("\nEnter your shift:");
                        shift = int.Parse(Console.ReadLine());

                        var encrypted = cipherService.Encrypt(message, shift);
                        Console.WriteLine($"--> Encrypted Message: {encrypted} <--");
                        cipherService.SaveCipher(encrypted, shift);
                        break;
                        
                    case "2":
                        Console.WriteLine("\nEnter your message:");
                        message = Console.ReadLine();

                        Console.WriteLine("\nEnter your shift:");
                        shift = int.Parse(Console.ReadLine());

                        var decrypted = cipherService.Decrypt(message, shift);
                        Console.WriteLine($"--> Decrypted Message: {decrypted} <--");
                        break;

                    case "3":
                        var ciphers = cipherService.GetAllCiphers();
                        foreach (var cipher in ciphers)
                        {
                            Console.WriteLine($"ID: {cipher.CipherID}, Message: {cipher.Message}, Shift: {cipher.Shift}, Date Created: {cipher.DateCreated}");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }
    }
}
