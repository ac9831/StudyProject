﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StudyProject.Sutdy_1.Model
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int GetAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - Birthday.Year;
            if (today < Birthday.AddYears(age))
                age--;
            return age + 1;
        }
    }
}
