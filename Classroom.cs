using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        List<Student> students;

        public Classroom(int capacity)
        {
            Capacity = capacity;
            students = new List<Student>();
        }
        public int Capacity { get; set; }
        public int Count { get { return students.Count; } }

        public string RegisterStudent(Student student)
        {
            if (Count < Capacity)
            {
                this.students.Add(student);
                return ($"Added student {student.FirstName} {student.LastName}");
            }

            return ("No seats in the classroom");

        }
        public string DismissStudent(string firstName, string lastName)
        {

            Student student = this.students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
            if (student is null)
            {
                return ("Student not found");
            }

            this.students.Remove(student);
            return ($"Dismissed student {firstName} {lastName}");

        }
        public string GetSubjectInfo(string subject) //??? Възможна грешка
        {
            if (this.students.Exists(x => x.Subject == subject))
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine($"Subject: {subject}");
                sb.AppendLine("Students:");

                foreach (var student in this.students.Where(x => x.Subject == subject))
                {
                    sb.AppendLine($"{student.FirstName} {student.LastName}");

                }

                return sb.ToString().Trim();
            }

            return ("No students enrolled for the subject");
        }

        public int GetStudentsCount()
        {
            return Count;
        }

        public Student GetStudent(string firstName, string lastName)
        {
            Student student = this.students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);

            return student;

        }
    }
}
