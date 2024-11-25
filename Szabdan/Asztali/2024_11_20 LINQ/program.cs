using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_20_IEnumerable
{
    internal class Program
    {
        static List<BankAccount> customers;
        static void Main(string[] args)
        {
            Adatok();

            Console.ReadLine();
        }

        private static void Adatok()
        {

            customers = new List<BankAccount>()
            {
                new BankAccount("John Doe", 1000.0, "123-456-789"),
                new BankAccount("Alice Smith", 0.0, "987-654-321"),
                new BankAccount("Robert Johnson", 1000000.0, "555-123-999"),
                new BankAccount("Sarah White", 50.5, "666-777-888"),
                new BankAccount("Superman", 5000.0, "000-000-001"),
                new BankAccount("Bruce Wayne", 0.0, "111-222-333"),
                new BankAccount("Peter Parker", 1200.75, "444-555-666"),
                new BankAccount("Tony Stark", 99999999.99, "1234-5678-9012-3456")
            };
        }
    }

    class BankAccount
    {  
        public string Name { get; private set; }
        public double Balance { get; private set; } //egyenleg
        public string AccountNumber { get; private set; }

        public BankAccount(string name, double balance, string accountNumber)
        {
            Name = name;
            Balance = balance;
            AccountNumber = accountNumber;
        }

        public override string ToString()
        {
            return $"Name: {Name} Balance: {Balance} AccountNumber: {AccountNumber}";
        }
    }
}
