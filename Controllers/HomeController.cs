using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppTest.Models;

namespace WebAppTest.Controllers
{
    public class HomeController : Controller
    {
        private WebAppTestContext db = new WebAppTestContext();
        public ActionResult Index()
        {
            var data = new MasterDAO();
            return View(data);
        }

        [HttpPost]
        public void EditGrade(int studentId, int subjectId, int grade)
        {
            var student = db.Students.Find(studentId);
            if (student.SubjectsGrades.Exists(x=>x.Subject.ID==subjectId))
            {
                student.SubjectsGrades.First(x=>x.Subject.ID == subjectId).Grade = grade;
            }
            else
            {
                student.SubjectsGrades.Add(subjectId, grade);
            }
        }
    }
}