using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Account<int> account1 = new Account<int>(12,5.56, "Иванов");
            account1.print();

            Account<string> account2 = new Account<string>("А150", 8.97, "Петров");
            account2.print();

            Console.ReadKey();
        }
    }
    public class Account<T>
    {
        private T accountNumber { get; set; }
        private double balance { get; set; }
        private string accountOwner { get; set; }

        public Account(T number, double balance, string owner)
        {
            accountNumber = number;
            this.balance = balance;
            accountOwner = owner;
        }
        public void print()
        {
            Console.Write("Номер счёта:{0} ", accountNumber);
            Console.Write("Баланс:{0} ", balance);
            Console.WriteLine("ФИО владельца:{0} ", accountOwner);
        }
      
    }
}
