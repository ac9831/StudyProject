using System;
using System.Collections.Generic;
using System.Text;

namespace StudyProject.Sutdy_1.Model
{
    class Student : Person
    {
        public int Grade { get; set; }
        public int ClassNumber { get; set; }

        public Student(int grade, int classNumber)
        {
            this.Grade = grade;
            this.ClassNumber = classNumber;
        }

    }
}
