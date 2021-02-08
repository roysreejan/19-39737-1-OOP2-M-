using System;

namespace Lab_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Sreejan Roy", "19-39737-1");
            s1.ShowInfo();
            s1.Name = "Sreejan Roy";
            s1.Id = "19-39737-1";
            s1.Department = "CSE";
            s1.Cgpa = 3.47f;
            Console.WriteLine("Name: " + s1.Name);
            Console.WriteLine("Id: " + s1.Id);
            Console.WriteLine("Department: " + s1.Department);
            Console.WriteLine("Cgpa: " + s1.Cgpa);
        }
    }
}
