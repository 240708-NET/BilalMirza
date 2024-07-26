using Repository;
using Models;
using System;

namespace Logic;
public class CaesarCipherService
{
    private readonly ICipherRepository _cipherRepository;

    public CaesarCipherService(ICipherRepository cipherRepository)
    {
        _cipherRepository = cipherRepository;
    }

    public string Encrypt(string message, int shift)
    {
        return ProcessText(message, shift);
    }

    public string Decrypt(string message, int shift)
    {
        return ProcessText(message, -shift);
    }

    private string ProcessText(string text, int shift)
    {
        string result = "";
        char[] alphabet = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz".ToCharArray();
        int alphabetLength = 26;

        foreach (char c in text.ToLower())
        {
            int position = Array.IndexOf(alphabet, c);

            // Executes proper decryption handling
            if (shift < 0)
            {
                shift = -(Math.Abs(shift) % alphabetLength); // set back to negative after calculations
            }
            else
            {
                shift = shift % alphabetLength;
            }


            if (position != -1)
            {
                int new_position = position + shift + 26;
                result += alphabet[new_position];
            }
            else
            {
                result += c;
            }
        }
        return result;
    }

    public void SaveCipher(string message, int shift)
    {
        var cipher = new Cipher
        {
            Message = message,
            Shift = shift,
            DateCreated = DateTime.Now
        };

        _cipherRepository.AddCipher(cipher);
    }

    public Cipher GetCipher(int id)
    {
        return _cipherRepository.GetCipher(id);
    }

    public IEnumerable<Cipher> GetAllCiphers()
    {
        return _cipherRepository.GetAllCiphers();
    }
}