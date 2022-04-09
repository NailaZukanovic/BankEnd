using BankSystem.Enums;
using System.ComponentModel.DataAnnotations;

namespace BankSystem.Models
{
    public class BankAccount
    {
        [Key]
        public Guid Id { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public BankAccountType AccountType { get; set; }
        public ForeignCurrencyType CurrencyType { get; set; }
        public int ExpoId { get; set; }
        public Expo Expo { get; set; }
        public decimal Balance { get; set; }
    }
}