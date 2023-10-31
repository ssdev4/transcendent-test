using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestProject.Data;
using TestProject.Models;
using TestProject.Repository.Abstraction;

namespace TestProject.Controllers
{
    public class NumberController : Controller
    {
        private readonly INumberService _numberService;

        public NumberController(INumberService numberService)
        {
            _numberService = numberService;
        }

        public async Task<IActionResult> Index()
        {
            var allNumbers = await _numberService.GetAllNumbersAsync();
            return View(allNumbers);
        }

        [HttpPost]
        public async Task<IActionResult> Calculate(NumberEntry model)
        {
            if (ModelState.IsValid)
            {
                await _numberService.AddNumberEntryAsync(model);
                return RedirectToAction("Index");
            }

            return View("Index", model);
        }
    }
}