using LawSchool.Data.Data.Entities;
using LawSchool.Service.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Law_School.Controllers
{
    public class StudentController : Controller
    {
        private readonly Istudent _istudent;

        public StudentController(Istudent istudent)
        {
            _istudent = istudent;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _istudent.GetAll();
            return View(result);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Student studentInput)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _istudent.Add(studentInput);
                    return RedirectToAction("Index", "Student");
                }
                return View(studentInput);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        //To check if the Id exist on the Db
        public async Task<IActionResult> Edit(int Id)
        {
            var doesIdExist = await _istudent.IfIdExist(Id);
            if (!doesIdExist)
            {
                return NotFound();
            }

            var result = await _istudent.GetById(Id);
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Student studentInput)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _istudent.Update(studentInput);

                    return RedirectToAction("Index", "Student");
                }
                return View(studentInput);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}