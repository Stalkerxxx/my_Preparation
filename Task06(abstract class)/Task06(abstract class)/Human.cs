namespace Task06_abstract_class_
{
    public abstract class Human
    {
        abstract internal string Name { get; set; }
        abstract internal string LastName { get;  set; }

        abstract internal string GetName(string name);
        abstract internal string GetLastName(string lastName);
        abstract internal void OutputToTheConsole();
    }
}
