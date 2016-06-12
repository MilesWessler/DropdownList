using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DropdownList.Models;
using DropdownList.ViewModel;
using System.Data.Entity;

namespace DropdownList.Controllers
{
    public class MusiciansController : Controller
    {

        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        public ActionResult Index(int? id)
        {
            var customers = _context.Musicians.Include(c => c.Instrument).ToList();

            return View(customers);
        }

        public ActionResult New()
        {
            var intruments = _context.Instruments.ToList();

            var viewModel = new MusicianFormViewModel
            {
                Instruments = intruments
            };

            return View("MusicianForm", viewModel);
        }

        public ActionResult Save(Musician musician)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MusicianFormViewModel
                {
                    Musician = musician,
                    Instruments = _context.Instruments.ToList()
                };
                return View("MusicianForm", viewModel);
            }

            if (musician.Id == 0)
                _context.Musicians.Add(musician);

            else
            {
                var musicianInDb = _context.Musicians.Single(c => c.Id == musician.Id);
                musicianInDb.Name = musician.Name;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Musicians");
        }
    }
}