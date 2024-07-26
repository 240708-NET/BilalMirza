using System;
using Logic;
using Repository;
using Microsoft.Extensions.DependencyInjection;

namespace UI;

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

        // Prints Logo and Description
        printUI();

        while (true) // While program is runnning
        {
            Console.WriteLine("Enter 1 to Encrypt, 2 to Decrypt, 3 to View All Ciphers, 4 to Delete a Cipher, or 0 to Exit:");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "0":
                    return;
                case "1":
                    try
                    {
                        ProcessMessage(cipherService, "Encrypt");
                    }
                    catch( Exception e )
                    {
                        Console.WriteLine( e.Message );
                    }
                    break;
                    
                case "2":
                    try
                    {
                        ProcessMessage(cipherService, "Decrypt");
                    }
                    catch( Exception e )
                    {
                        Console.WriteLine( e.Message );
                    }
                    break;

                case "3":
                    ViewAllCiphers(cipherService);
                    break;

                // case "4":
                //     try 
                //     {
                //         ViewCipherById(cipherService);
                //     }
                //     catch( Exception e )
                //     {
                //         Console.WriteLine( e.Message );
                //     }
                //     break;

                case "4":
                    try
                    {
                        DeleteCipherById(cipherService);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }

    // Methods

    // Shows an encrypted or decrypted message depending on user input
    static void ProcessMessage(CaesarCipherService cipherService, string direction)
    {
        Console.WriteLine("Enter your message:");
        var message = Console.ReadLine();

        Console.WriteLine("Enter your shift:");
        if (int.TryParse(Console.ReadLine(), out int shift)) // declares and initializes shift if input conversion to int is successful
        {
            if (direction == "Encrypt")
            {
                // Calls Encrypt() from Logic/CaesarCipherService
                var encrypted = cipherService.Encrypt(message, shift);
                Console.WriteLine($"--> Encrypted Message: {encrypted} <--");
                // Calls Encrypt() from Logic/CaesarCipherService - stores the encrypted message
                cipherService.SaveCipher(encrypted, shift);
            }
            else if (direction == "Decrypt")
            {
                // Calls Decrypt() from Logic/CaesarCipherService
                var decrypted = cipherService.Decrypt(message, shift);
                Console.WriteLine($"--> Decrypted Message: {decrypted} <--");
            }
        }
        else
        {
            Console.WriteLine("Invalid shift value.");
        }
    }

    // Shows all stored Cipher messages to user
    static void ViewAllCiphers(CaesarCipherService cipherService)
    {
        // Calls GetAllCiphers() from Logic/CaesarCipherService
        var ciphers = cipherService.GetAllCiphers();
        Console.WriteLine("------------------------------------------------------------------------------");
        foreach (var cipher in ciphers)
        {
            Console.WriteLine($"- ID: {cipher.CipherID}, Message: {cipher.Message}, Shift: {cipher.Shift}, Date Created: {cipher.DateCreated}");
        }
        Console.WriteLine("------------------------------------------------------------------------------");
    }

    // Shows a specific Cipher message by ID
    // static void ViewCipherById(CaesarCipherService cipherService)
    // {
    //     Console.WriteLine("Enter the Cipher ID:");
    //     if (int.TryParse(Console.ReadLine(), out int id))
    //     {
    //         var cipher = cipherService.GetCipher(id);
    //         Console.WriteLine("------------------------------------------------------------------------------");
    //         if (cipher != null)
    //         {
    //             Console.WriteLine($"ID: {cipher.CipherID}, Message: {cipher.Message}, Shift: {cipher.Shift}, Date Created: {cipher.DateCreated}");
    //             Console.WriteLine("------------------------------------------------------------------------------");
    //         }
    //         else
    //         {
    //             Console.WriteLine("Cipher not found.");
    //         }

    //     }
    //     else
    //     {
    //         Console.WriteLine("Invalid ID value.");
    //     }
    // }

    // Deletes a Cipher by ID
    static void DeleteCipherById(CaesarCipherService cipherService)
    {
        Console.WriteLine("Enter the ID of the cipher to delete:");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            cipherService.DeleteCipher(id);
            Console.WriteLine($"Cipher with ID {id} has been deleted.");
        }
        else
        {
            Console.WriteLine("Invalid ID.");
        }
    }

    // Prints Logo and Description
    static void printUI()
    {
        string intro = @"
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
";

        Console.Write (intro);
    }
}