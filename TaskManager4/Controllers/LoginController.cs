using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager4.Models;
using System.Web;
using Model;
using Newtonsoft.Json.Linq;
using System.Security.Claims;
using Newtonsoft.Json;
using Microsoft.Azure;

namespace TaskManager4.Controllers
{
    public class LoginController : Controller
    {
        private readonly UsuarioDbContext _context;
        public LoginController(UsuarioDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }   
        [HttpPost]
        public ActionResult Valida(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {

                var result = _context.Usuario.Where(x => x.usuario == model.usuario && x.password == model.password).SingleOrDefault();
                if (result != null)
                {
                   
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("Login", new { message = "Usuario y/o Password Vacios" });
                }
            }
            else
            {
                return RedirectToAction("Login", new { message = "Usuario y/o Password Vacios" });
            }

            
        }
        
        [Authorize]
        public ActionResult Logout()
        {
            //FormsAuthentication.SignOut();
            //Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
    }
}
