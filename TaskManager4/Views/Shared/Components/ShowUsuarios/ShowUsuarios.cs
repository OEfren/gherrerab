using Microsoft.AspNetCore.Mvc;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager4.Views.Shared.Components.ShowUsuarios
{
    public class ShowUsuarios: ViewComponent
    {
        private readonly IUsuarioService _usuarioService;
        public ShowUsuarios(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_usuarioService.ShowAll());
        }
    }
}
