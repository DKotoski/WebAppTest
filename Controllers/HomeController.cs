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

        public JsonResult EditGrade(int studentId, int subjectId, int grade)
        {
            var student = db.Students.Find(studentId);
            if (student.SubjectsGrades.ContainsKey(subjectId))
            {
                student.SubjectsGrades[subjectId] = grade;
            }
            else
            {
                student.SubjectsGrades.Add(subjectId, grade);
            }
            return Json("good");
        }
    }
}