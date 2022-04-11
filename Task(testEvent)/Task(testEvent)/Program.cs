using System;

namespace Task_testEvent_
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new(19345);
            account1.Notify += Account1_Notify;
            account1.Put(4000);
            account1.Take(2000);
            Console.ReadKey();
        }
        private static void Account1_Notify(string message) => Console.WriteLine(message);
    }
    class Account
    {
        public delegate void AccountHandler(string message);
        public event AccountHandler? Notify;
        public decimal CustomerAccount { get; private set; }
        public Account(decimal customerAccount) => CustomerAccount = customerAccount;
        public void Put(decimal sum)
        {
            CustomerAccount += sum;
            Notify?.Invoke($"The account received: {sum}");
        }
        public void Take(decimal sum)
        {
            if (CustomerAccount >= sum)
            {
                CustomerAccount -= sum;
                Notify?.Invoke($"Debited from the account: {sum}");
            }
            else Console.WriteLine($"Insufficient funds \n" +
                    $"available funds: {CustomerAccount}"); ;
        }
    }
}
