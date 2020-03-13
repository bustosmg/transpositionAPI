using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using transpositionAPI.Models;

namespace TranspositionWeb.Controllers
{
    public class AcordesController : Controller
    {
        // GET: Acordes
        public async Task<ActionResult> Index()
        {


            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://localhost:44347/api/acordes");
            var notasJson = JsonConvert.DeserializeObject<List<TNotas>>(json);

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