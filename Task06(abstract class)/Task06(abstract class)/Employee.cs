using System;

namespace Task06_abstract_class_
{
    class Employee : Human
    {
        internal override string Name { get; set; }
        internal override string LastName { get; set; }
        private int EmployeePersonalNumber { get; set; }
        private string LinkTaskList { get; set; }

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
            Console.WriteLine($"Employee full name: {LastName} {Name} \n" +
               $"Employee personal number: {EmployeePersonalNumber} \n" +
               $"Link task list: {LinkTaskList}");
        }

        public Employee(int employeePersonalNumber, string linkTaskList)
        {
            EmployeePersonalNumber = employeePersonalNumber;
            LinkTaskList = linkTaskList;
        }
    }
}
