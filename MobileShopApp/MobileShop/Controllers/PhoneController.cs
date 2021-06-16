using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MobileShop.Entities;
using MobileShop.Models;
using MobileShop.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MobileShop.Controllers
{
    public class PhoneController : Controller
    {
        private readonly IPhoneService _phoneService;
        private readonly IManufacturerService _manufacturerService;
        private readonly ILogger<PhoneController> _logger;

        public PhoneController(IPhoneService phoneService, IManufacturerService manufacturerService, ILogger<PhoneController> logger)
        {
            _phoneService = phoneService;
            _manufacturerService = manufacturerService;
            _logger = logger;
        }

        // GET: PhoneController
        public ActionResult Index()
        {
            var phones = _phoneService.GetPhones();
            return View(phones);
        }

        // GET: PhoneController/Details/5
        public ActionResult Details(int id)
        {
            var phone = _phoneService.GetPhoneByID(id);
            return View(phone);
        }

        // GET: PhoneController/Create
        public ActionResult Create()
        {
            var manufacturers = _manufacturerService.GetManufacturers();
            var dropdown = _phoneService.ManufacturerDropdown(manufacturers);
            ViewBag.ManufacturerList = dropdown;
            return View();
        }

        // POST: PhoneController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PhoneViewModel model)
        {
            var phone = new Phone();
            phone.Battery = model.Battery;
            phone.Display = model.Display;
            phone.ManufacturerID = model.ManufacturerID;
            phone.Memory = model.Memory;
            phone.Model = model.Model;
            phone.Price = model.Price;
            phone.ManufacturerName = model.ManufacturerName;

            _phoneService.Add(phone);
            _logger.LogInformation("New phone was created.");
            return RedirectToAction(nameof(Index));
        }

        // GET: PhoneController/Edit/5
        public ActionResult Edit(int id)
        {
            var phone = _phoneService.GetPhoneByID(id);
            var manufacturers = _manufacturerService.GetManufacturers();
            var dropdown = _phoneService.ManufacturerDropdown(manufacturers);
            ViewBag.ManufacturerList = dropdown;
            return View(phone);
        }

        // POST: PhoneController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Phone phone)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _phoneService.Edit(phone);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception exception)
            {

                throw;
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: PhoneController/Delete/5
        public ActionResult Delete(int id)
        {
            var phone = _phoneService.GetPhoneByID(id);
            return View(phone);
        }

        // POST: PhoneController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Phone phone)
        {
            try
            {
                _phoneService.Delete(phone);
                _logger.LogInformation("One phone was deleted.");
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public JsonResult CreateAJAX(Phone phone)
        {
             _phoneService.Add(phone);
            return Json(new { data = phone } );
        }

        [HttpPost]
        public IActionResult UploadImage()
        {
            try
            {
                var file = Request.Form.Files[0];
                var folderName = Path.Combine("wwwroot", "img");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = fileName;

                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                    return Ok(new { dbPath });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex);
            }
        }

    }
}
