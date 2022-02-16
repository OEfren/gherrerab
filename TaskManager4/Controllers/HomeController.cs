using Microsoft.AspNetCore.Mvc;
using Model.Domain;
using Service;
using System.Diagnostics;
using TaskManager4.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Model;
using System.Linq;

namespace TaskManager4.Controllers
{
    public class HomeController : Controller
    {
        private readonly UsuarioDbContext _context;
        private readonly IUsuarioService _usuarioService;
        public HomeController(IUsuarioService usuarioService , UsuarioDbContext context)
        {
            _usuarioService = usuarioService;
            _context = context;
        }
        

        public IActionResult Index()
        {
            string variable = "" ;
            if ( variable != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login","Login");
            }
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Insert(UsuarioViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", model);
            }
            var result = _context.Usuario.Where(x => x.usuario == model.usuario);
            if (result.Count() == 0)
            {
                var usuario = new Usuario
                {
                    usuario = model.usuario,
                    password = model.password,
                    tipo_usuario = model.tipo_usuario,
                    nombre = model.nombre,
                    apellidos = model.apellidos
                };
                _usuarioService.Create(usuario);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Create",new {message="Usuario ya existe" });
            }
            
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
