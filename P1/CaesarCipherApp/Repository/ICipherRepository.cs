using Models;

namespace Repository
{
    public interface ICipherRepository
    {
        void AddCipher(Cipher cipher);
        Cipher GetCipher(int id);
        IEnumerable<Cipher> GetAllCiphers();
    }
}
