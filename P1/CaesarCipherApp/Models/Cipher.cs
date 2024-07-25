namespace Models
{
    public class Cipher
    {
        public int CipherID { get; set; }
        public string Message { get; set; }
        public int Shift { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
