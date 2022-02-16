using Microsoft.AspNetCore.Mvc;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager4.Views.Shared.Components.ShowTipoActividad
{
    public class ShowActividades : ViewComponent
    {
        private readonly IActividadService _actividadService;
        public ShowActividades(IActividadService actividadService)
        {
            _actividadService = actividadService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_actividadService.ShowAll());
        }
    }
}
