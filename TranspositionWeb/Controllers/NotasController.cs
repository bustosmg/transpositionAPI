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
    public class NotasController : Controller
    {
        // GET: Notas
        public async Task<ActionResult> Index()
        {
            //bin\Release\netcoreapp3.1\publish\T1 
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://transpositionapi.azurewebsites.net/api/notas");

            //var oAPItrans = new NotasController();        
            var notasJson = JsonConvert.DeserializeObject<List<TNotas>>(json);

            return View(notasJson);
        }

        // GET: Notas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Notas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Notas/Create
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

        // GET: Notas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Notas/Edit/5
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

        // GET: Notas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Notas/Delete/5
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