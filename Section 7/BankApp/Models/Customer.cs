﻿namespace BankApp.Models
{
    public class Customer
    {
        public int Id { get;set;}
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public double Balance { get;set; }
    }
}
