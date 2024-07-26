using Models;
using System.Linq;

namespace Repository;

public class CipherRepository : ICipherRepository
{
    private readonly CipherContext _context;

    public CipherRepository(CipherContext context)
    {
        _context = context;
    }

    public void AddCipher(Cipher cipher)
    {
        _context.Ciphers.Add(cipher);
        _context.SaveChanges();
    }

    public Cipher GetCipher(int id)
    {
        return _context.Ciphers.Find(id);
    }

    public List<Cipher> GetAllCiphers()
    {
        return _context.Ciphers.ToList();
    }

    public void DeleteCipher ( int id )
    {
        var foundCipher = _context.Ciphers.Find(id);
        _context.Ciphers.Remove(foundCipher);
        _context.SaveChanges();
    }
}
