using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Sreejan", "19-39737-1", 3.47F);
            Student s2 = new Student("Rahim", "1234", 3.7F);
            Student s3 = new Student("Karim", "2905", 3.8F);

            Department d1 = new Department("Computer Science", "CS");
            Department d2 = new Department("Electrical & Electronic Engineering", "EEE");

            s1.Dept = d1;
            s2.Dept = d2;
            s3.Dept = d1;

            s1.ShowDepartment();

            s2.ShowDepartment();
            ;
            s3.ShowDepartment();


            d1.Name = "Computer Science & Engineering"; 

            s1.ShowDepartment();

            //one to many

            d1.AddStudent(s1);
            d1.AddStudent(s2);

            d1.PrintStudent();
        }
    }
}
    

