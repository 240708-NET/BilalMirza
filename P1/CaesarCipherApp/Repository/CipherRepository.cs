using Models;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
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

        public IEnumerable<Cipher> GetAllCiphers()
        {
            return _context.Ciphers.ToList();
        }
    }
}
