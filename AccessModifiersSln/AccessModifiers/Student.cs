using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
    public class Student
    {
        string name;
        string id;
        double cgpa;
        readonly int credit;
        //properties or accessors
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string Id
        {
            set { id = value; }
            get { return id; }
        }

        public double Cgpa
        {
            set { cgpa = value; }
            get { return cgpa; }
        }

        //constructor
        public Student()
        {
            Console.WriteLine("Student created with default");
            credit = 145;
        }
        public Student(string name, string id)
        {
            Console.WriteLine("Student created with 2 parameter");
            this.name = name;
            this.id = id;
            credit = 148;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name is: " + name);
            Console.WriteLine("Id is: " + id);
            Console.WriteLine("Cgpa is: " + cgpa);
        }
    }
}
