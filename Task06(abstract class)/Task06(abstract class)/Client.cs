using System;

namespace Task06_abstract_class_
{
    class Client : Human
    {   
        internal override string Name { get; set; }
        internal override string LastName { get; set; }
        private long NumberClient { get; set; }
        private long BankAccountNumber { get; set; }

        internal override string GetLastName(string lastName)
        {
            return LastName = lastName;
        }

        internal override string GetName(string name)
        {
            return Name = name;
        }

        internal override void OutputToTheConsole()
        {
            Console.WriteLine($"Client full name: {LastName} {Name} \n" +
                $"Number client: {NumberClient} \n" +
                $"Bank account number: {BankAccountNumber}");
        }
        public Client(long numberClient, long bankAccountNumber)
        {
            NumberClient = numberClient;
            BankAccountNumber = bankAccountNumber;
        }
    }
}
