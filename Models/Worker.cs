using System.ComponentModel.DataAnnotations;

namespace BankSystem.Models
{
    public class Worker
    {
        [Key]
        public int Id { get; set; }
        public string JMBG { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ParentName { get; set; }
        public string Address { get; set; }
        public string PhoneNumbers { get; set; }
        public string EmailAddresses { get; set; }
        public string Role { get; set; }
        public DateTime HiredFromDate { get; set; }
        public DateTime HiredUntilDate { get; set; }
        public int ExpoId { get; set; }
        public Expo Expo { get; set; }
        public bool IsExpoChief { get; set; }
    }
}
