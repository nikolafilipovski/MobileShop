using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MobileShop.Entities;
using MobileShop.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Controllers
{
    public class ManufacturerController : Controller
    {
        private readonly IManufacturerService _manufacturerService;

        public ManufacturerController(IManufacturerService manufacturerService)
        {
            _manufacturerService = manufacturerService;
        }

        // GET: ManufacturerController
        public ActionResult Index()
        {
            var manufacturers = _manufacturerService.GetManufacturers();
            return View(manufacturers);
        }

        // GET: ManufacturerController/Details/5
        public ActionResult Details(int id)
        {
            var manufacturer = _manufacturerService.GetManufacturerByID(id);
            return View(manufacturer);
        }

        // GET: ManufacturerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ManufacturerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Manufacturer manufacturer)
        {
            try
            {
                _manufacturerService.Add(manufacturer);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ManufacturerController/Edit/5
        public ActionResult Edit(int id)
        {
            var manufacturer = _manufacturerService.GetManufacturerByID(id);
            return View(manufacturer);
        }

        // POST: ManufacturerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Manufacturer manufacturer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _manufacturerService.Edit(manufacturer);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception exception)
            {

                throw;
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: ManufacturerController/Delete/5
        public ActionResult Delete(int id)
        {
            var manufacturer = _manufacturerService.GetManufacturerByID(id);
            return View(manufacturer);
        }

        // POST: ManufacturerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Manufacturer manufacturer)
        {
            try
            {
                _manufacturerService.Delete(manufacturer);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
