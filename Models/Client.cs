﻿namespace BankSystem.Models
{
    public class Client
    {
        public int Id { get; set; }
        public int BankAccountId { get; set; }
        public BankAccount BankAccount { get; set; }
        public string JMBG { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ParentName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
