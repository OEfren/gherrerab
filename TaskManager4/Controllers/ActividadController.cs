using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Domain;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager4.Models;


namespace TaskManager4.Controllers
{
    public class ActividadController : Controller
    {
        
        private readonly IActividadService _actividadService;
        public ActividadController(IActividadService actividadService)
        {
            _actividadService = actividadService;
        }
        // GET: TipoActividadController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TipoActividadController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TipoActividadController/Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Insert(ActividadViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", model);
            }

            var actividad = new Actividad
            {
                id_creador = model.id_creador,
                id_asignador = model.id_asignador,
                id_asignado = model.id_asignado,
                id_tipo_actividad = model.id_tipo_actividad,
                detalle = model.detalle,
                finalizada = false
                

            };
            if (_actividadService.Create(actividad))
            {
                return RedirectToAction("Index", "TipoActividad");
            }
            else
            {
                return View("Create", model);
            }
        }
        // POST: TipoActividadController/Create


        // GET: TipoActividadController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TipoActividadController/Edit/5
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

        // GET: TipoActividadController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TipoActividadController/Delete/5
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
