﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomProject
{
    public class Student
    {
        //FirstName: string
        //LastName: string
        //Subject: string

        public Student(string firstName, string lastName, string subject)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
    }
}
