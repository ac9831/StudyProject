using System;
using System.Collections.Generic;
using System.Text;

namespace StudyProject.Sutdy_1.Model
{
    class Student : Person
    {
        public int Grade { get; set; }
        public int ClassNumber { get; set; }

        public Student(string name, DateTime brithDay, int grade, int classNumber)
        {
            this.Name = name;
            this.Birthday = Birthday;
            this.Grade = grade;
            this.ClassNumber = classNumber;
        }

    }
}
