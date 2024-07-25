using Repository;
using Models;
using System;

namespace Logic
{
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
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            int alphabetLength = alphabet.Length;

            foreach (char c in text.ToLower())
            {
                int position = Array.IndexOf(alphabet, c);

                if (position != -1)
                {
                    int new_position = (position + shift + alphabetLength) % alphabetLength;
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
}
