using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileShop.Entities;
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

        public PhoneController(IPhoneService phoneService)
        {
            _phoneService = phoneService;
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
            return View();
        }

        // POST: PhoneController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Phone phone)
        {
            try
            {
                _phoneService.Add(phone);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PhoneController/Edit/5
        public ActionResult Edit(int id)
        {
            var phone = _phoneService.GetPhoneByID(id);
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
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
