using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppTest.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public virtual List<StudentSubject> SubjectsGrades;
        public int NumOfSubjects { get { return SubjectsGrades.Count; } }
        public double AverageGrade { get
            {
                if (SubjectsGrades.Count == 0) return 0;
                return SubjectsGrades.Select(x => x.Grade).Average();
            }
        }
        public Student()
        {
            SubjectsGrades = new List<StudentSubject>();
        }
    }
}