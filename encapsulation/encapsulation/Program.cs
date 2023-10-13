using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    class Account
    {
        public int accountBalance = 1000;

        public int Balance
        {
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("you can nit add negative value");
                }
                else
                {
                    accountBalance = accountBalance + value;
                }
            }
            get
            {
                return accountBalance;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            account.Balance = Convert.ToInt32 (Console.ReadLine()) ;
            Console.WriteLine(account.Balance);
            Console.ReadLine();
        }
    }
}
