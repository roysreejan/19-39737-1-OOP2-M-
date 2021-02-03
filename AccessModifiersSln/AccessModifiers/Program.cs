using System;
using AccessModifiers;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10; //literals
            const int credit = 148;

            Student s1 = new Student("Sreejan Roy","19-39737-1");
            s1.ShowInfo();
            s1.Name = "Sreejan Roy";
            s1.Id = "19-39737-1";
            s1.Cgpa = 3.47;
            Console.WriteLine("Name: " + s1.Name);
            Console.WriteLine("Id: " + s1.Id);
            Console.WriteLine("Cgpa: " + s1.Cgpa);

        }
    }
}
