﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppTest.Models
{
    public class MasterDAO
    {
        private WebAppTestContext db = new WebAppTestContext();
        public List<Student> Students { get { return db.Students.OrderBy(x => x.ID).ToList(); } }
        public List<Subject> Subjects { get { return db.Subjects.OrderBy(x => x.ID).ToList(); } }
    }
}