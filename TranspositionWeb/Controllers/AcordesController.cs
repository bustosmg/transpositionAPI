﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TranspositionWeb.Controllers
{
    public class AcordesController : Controller
    {
        // GET: Acordes
        public async Task<ActionResult> Index()
        {

            return View();
        }

        // GET: Acordes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Acordes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Acordes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Acordes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Acordes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Acordes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Acordes/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}