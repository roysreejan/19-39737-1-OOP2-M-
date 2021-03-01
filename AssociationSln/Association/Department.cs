using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Department
    {

        private string name;
        private string id;

        private int studentCount;
        private Student[] students;

        public Department()
        {
            students = new Student[60];
        }
        public Department(string name, string id)
        {
            this.Name = name;
            this.Id = id;
            students = new Student[60];
        }
        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }
        public string Id
        {
            set { this.id = value; }
            get { return this.id; }
        }
        public int StudentCount
        {
            set { this.studentCount = value; }
            get { return this.studentCount; }
        }
        public void AddStudent(params Student[] stdns)
        {
            foreach (Student s in stdns)
            {
                this.students[this.StudentCount++] = s;
                s.Dept = this;
            }
        }

        public Student GetStudent(string id)
        {

            return null;
        }

        public void PrintStudent()
        {
            for (int i = 0; i < studentCount; i++)
            {
                students[i].ShowInfo();
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Department Name: {0}", this.Name);
            Console.WriteLine("Department Id: {0}", this.Id);

        }
    }
}
    

