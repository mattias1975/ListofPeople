using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ListofPeople.Models;

namespace ListofPeople.Controllers
{
    public class PeopleController : Controller
    {

        readonly IPeopleRespontity _PeopleRepository;
        private object _peopleRepository;

        public PeopleController(IPeopleRespontity PeopleRepository)
        {
            _peopleRepository = IPeopleRespontity;
            {
            }

            public IActionResult Index()
            {
                return View(_peopleRepository.Allpeople());
            }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("City,Name")] People people)
        {
            if (ModelState.IsValid)
            {
                _peopleRepository.Create(People.name, people.phone, People.Cities);
                return RedirectToAction("Index");
            }
            return View(people);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return BadRequest();
            }

            People people = _peopleRepository.FindById((int)id);

            if (people == null)
            {
                return NotFound();
            }

            return PartialView("_Deletepeople", people);
        }

        [HttpPost]
        public IActionResult ConfirmDelete(int id, int itemId)
        {
            if (id == itemId)
            {
                if (_peopleRepository.Delete(id))
                {
                    return Content("");
                }

                return NotFound();
            }

            return BadRequest();
        }
    }
    }
