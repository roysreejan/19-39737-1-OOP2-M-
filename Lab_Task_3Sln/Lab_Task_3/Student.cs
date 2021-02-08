using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Task_3
{
    class Student
    {
        private string name;
        private string id;
        private string department;
        private float cgpa;
        //properties
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
        public string Department
        {
            set { department = value; }
            get { return department; }
        }

        public float Cgpa
        {
            set { cgpa = value; }
            get { return cgpa; }
        }

        //Constructor
        public Student()
        {
            Console.WriteLine("Student created with default");
        }
        public Student(string name, string id)
        {
            Console.WriteLine("\nStudent created with 2 parameter");
            this.name = name;
            this.id = id;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name is: " + name);
            Console.WriteLine("Id is: " + id);
            Console.WriteLine("Department is: " + department);
            Console.WriteLine("Cgpa is: " + cgpa);
        }
    }
}
