using CaesarCipher.Models;

namespace CaesarCipher.Repo

public interface ICipher
{
    int Id { get; set; }
    string Message { get; set; }
    int Shift { get; set; }
    DateTime DateCreated { get; set; }
    string Encrypt();
    string Decrypt();
}
