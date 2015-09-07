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
        public Dictionary<int, int> SubjectsGrades{ get; set; }
        public int NumOfSubjects { get { return SubjectsGrades.Count; } }
        public double AverageGrade { get
            {
                return SubjectsGrades.Select(x => x.Value).Average();
            }
        }
    }
}