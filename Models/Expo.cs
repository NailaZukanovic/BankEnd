namespace BankSystem.Models
{
    public class Expo
    {
        public int Id { get; set; }
        public string RegistrationNumber { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public List<Worker> Workers { get; set; }
        public List<BankAccount> BankAccounts { get; set; }
    }
}
