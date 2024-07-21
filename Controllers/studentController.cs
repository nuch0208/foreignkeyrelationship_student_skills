using System.Collections.Immutable;
using foreignkeyrelationship_student_skills.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace foreignkeyrelationship_student_skills.Controllers
{
    public class studentController : Controller
    {
        mycontext my_context;
        public studentController(mycontext my)
        {
            my_context = my;
        }
        public IActionResult Index()
        {
            var fetch = my_context.students.Include(x=>x.Skill).ToList();
            return View(fetch);
        }
         public IActionResult addskill()
        {
            return View();
        }

        [HttpPost]
        public IActionResult addskill(skill s)
        {
            my_context.Add(s);
            my_context.SaveChanges();
            ModelState.Clear();
            ViewBag.success="skill has been added";
            return View();
        }

        public IActionResult addstudent()
        {
            ViewBag.getskill = my_context.skills.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult addstudent(student s)
        {
            my_context.students.Add(s);
            my_context.SaveChanges();
            ModelState.Clear();
            return RedirectToAction("addstudent");
        }
    }
}