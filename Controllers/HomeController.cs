using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PC04.Data;
using PC04.Models;

namespace PC04.Controllers
{
    public class HomeController : Controller
    {
        private readonly RegistroContext _context;

        public HomeController(RegistroContext context)
        {
             _context = context;
        }

        public IActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registro(Registro r)
        {
            if(ModelState.IsValid){

                 _context.Add(r);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(r);
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
