using Models;

namespace Repository
{
    public interface ICipherRepository
    {
        void AddCipher(Cipher cipher);
        Cipher GetCipher(int id);
        List<Cipher> GetAllCiphers();
    }
}
