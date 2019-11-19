using System;
using System.Collections.Generic;
using System.Linq;
using Gradebook.Enums;

namespace Gradebook.GradeBooks
{
    public abstract class BaseGradeBook
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public bool IsWeighted { get; set; }
        public GradeBookType Type { get; set; }

        public BaseGradeBook(string name, bool isWeighted)
        {
            Name = name;
            IsWeighted = isWeighted;
            Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            // student.Name == null || ""
            if (string.IsNullOrEmpty(student.Name))
                throw new ArgumentException("A name is required to add a Student to the List");
            Students.Add(student);
        }

        public void RemoveStudent(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("A name is required to remove a Student from the List ");

            var student = Students.FirstOrDefault(e => e.Name == name);

            if (student == null)
            {
                Console.WriteLine("Student {0} is not found, try again", name);
            }

            Students.Remove(student);         
        }

        public void AddGrade(string name, double score)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("A name is required to add grade to the Student");

            var student = Students.FirstOrDefault(e => e.Name == name);

            if (student == null)
            {
                Console.Write("The student with this particular name is not found");
                return;
            }

            student.AddGrade(score);
        }

        public void RemoveGrade(string name, double score)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("A name is required to add grade into the ");

            var student = Students.FirstOrDefault(e => e.Name == name);

            if (student == null)
            {
                Console.WriteLine("The studnet with this particular name is not found");
                return;
            }

            student.RemoveGrade(score);
        }

        public void ListStudents()
        {
            foreach(var student in Students)
            {
                Console.WriteLine("{0} : {1} : {2}", student.Name, student.Type, student.Enrollment);
            }
        }
    }
}
