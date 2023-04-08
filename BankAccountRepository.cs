using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheProject
{
    public class BankAccountRepository
    {

        static public List<BankAccount> GetList()
        {
            List<BankAccount> list = new List<BankAccount>()
            {
                new BankAccount("Breaker","Herald",676576,69465936)
            };
            return list;
        }

        
    }
}
