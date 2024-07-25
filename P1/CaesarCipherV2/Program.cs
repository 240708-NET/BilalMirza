class Program
{
    static void Main()
    {
        var cipher = new CaesarCipher
        {
            Message = "hello world",
            Shift = 4
        };

        // Test Encryption
        var encrypted = cipher.Encrypt();
        Console.WriteLine($"Encrypted: {encrypted}");

        // Test Decryption
        var decrypted = cipher.Decrypt();
        Console.WriteLine($"Decrypted: {decrypted}");
    }
}