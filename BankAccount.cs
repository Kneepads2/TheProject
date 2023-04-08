using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TheProject
{
    [Serializable]
    public class BankAccount
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public double SavingsBalance { get; set; }
        public double ChequeBalance { get; set; }

        public BankAccount() { }
        public BankAccount(string username, string password, double savingsBalance, double chequeBalance)
        {
            Username = username;
            Password = password;
            SavingsBalance = savingsBalance;
            ChequeBalance = chequeBalance;

        }
        public override string ToString()
        {
            return $"{Username}, {Password} , {SavingsBalance}, {ChequeBalance}";
        }
    }
}
