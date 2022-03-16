using System;

namespace Task06_abstract_class_
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new(192991233, 33412345);
            client1.GetName("Nikolay");
            client1.GetLastName("Kuzin");
            Console.WriteLine("First client: ");
            client1.OutputToTheConsole();

            Client client2 = new(192144245, 33434248);
            client2.GetName("Nik");
            client2.GetLastName("Kuze");
            Console.WriteLine("Second client: ");
            client2.OutputToTheConsole();

            Employee cashier = new(18298672, 
                "https://metanit.com/sharp/tutorial/3.8.php");
            cashier.GetName("Nikita");
            cashier.GetLastName("Kuzert");
            Console.WriteLine("Cashier: ");
            cashier.OutputToTheConsole();
        }
    }
}
