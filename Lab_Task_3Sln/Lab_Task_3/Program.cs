using System;

namespace Lab_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student
            Student s1 = new Student();
            s1.Name = "Sreejan Roy";
            s1.Id = "19-39737-1";
            s1.Department = "CSE";
            s1.Cgpa = 3.47f;
            s1.ShowInfo();

            Student s2 = new Student("Sreejan Roy", "19-39737-1");
            s2.ShowInfo();

            //Triangle
            Triangle t1 = new Triangle();
            t1.X = 10;
            t1.Y = 5;
            t1.Z = 8;
            t1.ShowInfo();
            t1.TestTriangle();

            Triangle t2 = new Triangle(10, 10, 10);
            t2.ShowInfo();
            t2.TestTriangle();


            //Account
            Account a1 = new Account();
            a1.AccName = "Sreejan Roy";
            a1.Acid = "19397371";
            a1.Balance = 10000;

            a1.Deposit(1000);
            Console.WriteLine("After Deposit: ");
            Console.WriteLine("Name: {0}\nAcid: {1}\nBalance: {2}\n", a1.AccName, a1.Acid, a1.Balance);

            a1.Withdraw(500);
            Console.WriteLine("After Withdraw: ");
            Console.WriteLine("Name: {0}\nAcid: {1}\nBalance: {2}\n", a1.AccName, a1.Acid, a1.Balance);

            Account a2 = new Account("Sreejan Roy", "152375", 50000);
            a2.Deposit(1000);
            Console.WriteLine("After Deposit: ");
            Console.WriteLine("Name: {0}\nAcid: {1}\nBalance: {2}\n", a2.AccName, a2.Acid, a2.Balance);

            a2.Withdraw(500);
            Console.WriteLine("After Withdraw: ");
            Console.WriteLine("Name: {0}\nAcid: {1}\nBalance: {2}", a2.AccName, a2.Acid, a2.Balance);


            //Course
            Course c1 = new Course();
            c1.CourseName = "OOP1";
            c1.CourseCode = "CSC1205";
            c1.CourseCredit = 3;
            c1.ShowCourseInfo();

            Course c2 = new Course("OOP2", "CSC2210", 3);
            c2.ShowCourseInfo();
        }
    }
}
