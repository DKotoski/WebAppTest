using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppTest.Models
{
    public class StudentSubject
    {
        public int ID { get; set; }
        public Subject Subject{ get; set; }
        public int Grade { get; set; }
    }
}