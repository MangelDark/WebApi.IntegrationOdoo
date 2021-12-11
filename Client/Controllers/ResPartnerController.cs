using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Controllers
{
    public class ResPartnerController : Controller
    {
        // GET: ResPartnerController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ResPartnerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ResPartnerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ResPartnerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ResPartnerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ResPartnerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ResPartnerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ResPartnerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
