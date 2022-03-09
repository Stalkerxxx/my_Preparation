using System;

namespace Task_01__Student_
{//реализовать класс студент Свойства 1 ФИО 2 Группа 3 Средний бал Методы 1 Print 2 Zapoln-заполняет
 //классфункция принимает массив обьектов студент и возращает ФИО лучшего!! 
    class Student
    {
        //Class properties
        public string FullName { get; set; }
        public int GroupNumber { get; set; }
        public double AverageScore { get; set; }
        //Class methode
        public void PrintStudent() => Console.WriteLine($"Full name of the student: {FullName} " +
                $"\nGroup number: {GroupNumber}" +
                $"\nAverage score of the student: {AverageScore}");
        
        //Class constructor:
        public Student(string fullName, int groupNumber, double averageScore)
        {
            FullName = fullName;
            GroupNumber = groupNumber;
            AverageScore = averageScore;
        }
    }
}
