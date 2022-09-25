using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ExamSample2.Models;
using ExamSample2.Models.Entities;

namespace ExamSample2.Controllers
{
    public class CountryController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CountryController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Country
        public ActionResult Index()
        {
            var country = _context.Country.ToList();
            return View(country);
        }

        public async Task<ActionResult> addCountry(Country country)
        {
            _context.Country.Add(country);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}