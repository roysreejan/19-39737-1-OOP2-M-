using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Task_3
{
    class Course
    {
        private string courseName;
        private string courseCode;
        private int courseCredit;
        //properties
        public string CourseName
        {
            set { courseName = value; }
            get { return courseName; }
        }

        public string CourseCode
        {
            set { courseCode = value; }
            get { return courseCode; }
        }

        public int CourseCredit
        {
            set { courseCredit = value; }
            get { return courseCredit; }
        }

        //constructor
        public Course()
        {
            Console.WriteLine("\nCourse created with default");
        }
        public Course(string courseName, string courseCode, int courseCredit)
        {
            Console.WriteLine("\nCourse created with 3 parameter");
            this.courseName = courseName;
            this.courseCode = courseCode;
            this.courseCredit = courseCredit;
        }
        public void ShowCourseInfo()
        {
            Console.WriteLine("Course Name: " + this.courseName);
            Console.WriteLine("Course Code: " + this.courseCode);
            Console.WriteLine("Course Credit: " + this.courseCredit);
        }
    }
}
