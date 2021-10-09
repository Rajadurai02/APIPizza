using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaApplicationMVC.Models;
using PizzaApplicationMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplicationMVC.Controllers
{
    public class PizzaController : Controller
    {
        private readonly PizzaService _service;

        public PizzaController(PizzaService service)
        {
            _service = service;
        }
        // GET: PizzaController
        public ActionResult Index()
        {
            List<PizzaDTO> pizzas = null;
            if (TempData["token"] != null)
            {
                try
                {
                    pizzas = _service.AllPizzas(TempData.Peek("token").ToString());
                }
                catch (Exception)
                {
                    return View();
                }
            }
            return View(pizzas);
        }

        // GET: PizzaController/Details/5
        public ActionResult Details(int id)
        {
            PizzaDTO pizza = null;
            id = 1;
            if (TempData["token"] != null)
            {
                try
                {
                    pizza = _service.GetPizza(id,TempData.Peek("token").ToString());
                }
                catch (Exception)
                {
                    return View();
                }
            }
            return View(pizza);
        }

        // GET: PizzaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PizzaController/Create
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

        // GET: PizzaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PizzaController/Edit/5
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

        // GET: PizzaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PizzaController/Delete/5
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
