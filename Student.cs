using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using Gradebook.Enums;

namespace Gradebook
{
    public class Student
    {
        public string Name { get; set; }

        public StudentType Type { get; set; }

        public EnrollmentType Enrollment { get; set; }

        public List<double> Grades { get; set; }
        [JsonIgnore]

        public double AverageGrade
        {
            get
            {
                return Grades.Average();
            }
        }
        [JsonIgnore]

        public char LetterGrade { get; set; }
        [JsonIgnore]
    }
}
