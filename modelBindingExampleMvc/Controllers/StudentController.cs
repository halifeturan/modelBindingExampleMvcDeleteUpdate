using Microsoft.AspNetCore.Mvc;
using modelBindingExampleMvc.Models.Context;
using modelBindingExampleMvc.Models.Entities;
using System.Linq;

namespace modelBindingExampleMvc.Controllers
{
    public class StudentController : Controller
    {
        StudentsContext db = new StudentsContext();
        public IActionResult Index()
        {

            var students = db.Students.ToList();
            return View(students);
        }

        [HttpPost]
        public IActionResult StudentDelete(int id)
        {
            using (var db = new StudentsContext())
            {
                var students = db.Students.Find(id);
                db.Students.Remove(students);
                db.SaveChanges(); 
            }
            return RedirectToAction("Index", db.Students.ToList());
        }
        [HttpPost]
        public IActionResult StudentCreate(Student student)
        {
            using (var db = new StudentsContext())
            {
                db.Students.Add(student);
                db.SaveChanges();
            }
           return RedirectToAction("Index", db.Students.ToList());
        }
        public IActionResult StudentCreate()
        {
            return View(db.Students.ToList());
        }

        public IActionResult StudentUpdate(int id)
        {
            var student = db.Students.Find(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult StudentUpdate(Student student)
        {
            using (var db = new StudentsContext())
            {
                db.Students.Update(student);
                db.SaveChanges();
            }
            return RedirectToAction("Index", db.Students.ToList());
        }

    }
}
