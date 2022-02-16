using Microsoft.AspNetCore.Mvc;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager4.Views.Shared.Components.ShowTipoActividad
{
    public class ShowTipoActividad : ViewComponent
    {
        private readonly ITipoActividadService _tipoActividadService;
        public ShowTipoActividad(ITipoActividadService tipoActividadService)
        {
            _tipoActividadService = tipoActividadService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_tipoActividadService.ShowAll());
        }
    }
}
