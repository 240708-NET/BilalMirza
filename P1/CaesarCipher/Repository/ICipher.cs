using CaesarCipher.Models;
using System;

namespace CaesarCipher.Repository
{
    public interface ICipher
    {
        int CipherID { get; set; } // Match the property name in the Cipher class
        string Message { get; set; }
        int Shift { get; set; }
        DateTime DateCreated { get; set; }
        string Encrypt();
        string Decrypt();
    }
}
