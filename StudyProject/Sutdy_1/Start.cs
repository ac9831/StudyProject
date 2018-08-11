using StudyProject.Sutdy_1.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyProject.Sutdy_1
{
    class Start
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("문제 1번");
            Bread bread = new Bread();
            bread.GetPrice();

            Console.WriteLine("문제 2번");
            Class cls = new Class();
            cls.X = 50;
            cls.Y = 100;
            Struct str = new Struct();
            str.X = 50;
            str.Y = 100;

            PrintObject(cls, str);
            Console.WriteLine("cls.X : {0}, cls.Y : {1}, str.X : {2}, str.Y : {3}", cls.X, cls.Y, str.X, str.Y);

            Console.WriteLine("문제 3번");
            Student student = new Student("bincent", DateTime.Now.AddYears(-30), 1, 1);
            Console.WriteLine("Name : {0}, Grade : {1}, ClassNumber : {2}, BirthDay : {3}, Age : {4}", student.Name, student.Grade, student.ClassNumber, student.Birthday, student.GetAge());
        }

        public static void PrintObject(Class cls, Struct str)
        {
            cls.X = cls.X * 2;
            cls.Y = cls.Y * 2;
            str.X = str.X * 2;
            str.Y = str.Y * 2;
        }
    }
}
