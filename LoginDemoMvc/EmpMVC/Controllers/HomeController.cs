using System.Diagnostics;
using EmpMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace EmpMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmpDbContext _dbContext;

        public HomeController(EmpDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Emp emp)
        {
            var authUser = _dbContext.emps.Where(e => e.Ename == emp.Ename && e.Password == emp.Password).FirstOrDefault();
            if (authUser != null)
            {
                return RedirectToAction("Show");
            }
            else
            {
                return View("Login");
            }

        }
        public IActionResult Show()
        {
            var empDetails = _dbContext.empdatas.ToList();
            return View(empDetails);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Submit(EmpData empData)
        {
            _dbContext.empdatas.Add(empData);
            _dbContext.SaveChanges();
            return RedirectToAction("Show");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            EmpData emp = _dbContext.empdatas.Find(id);
            return View(emp);
        }

        [HttpPost]
        public IActionResult Edit(EmpData emp)
        {
            _dbContext.empdatas.Update(emp);
            _dbContext.SaveChanges();
            return RedirectToAction("Show");
        }
        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid) 
            {
                EmpData emp = _dbContext.empdatas.Find(id);
                _dbContext.empdatas.Remove(emp);
                _dbContext.SaveChanges();
                return RedirectToAction("Show");

            }
            else
            {
                return RedirectToAction("Error");
            }
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
