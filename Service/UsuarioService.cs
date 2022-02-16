using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IUsuarioService
    {
        bool Create(Usuario model);
        IEnumerable<Usuario> ShowAll();
    }
    public class UsuarioService : IUsuarioService
    {
        private readonly UsuarioDbContext _context;
        public UsuarioService( UsuarioDbContext context)
        {
            _context = context;
        }
        public bool Create(Usuario model)
        {
            try
            {
                _context.Entry(model).State = EntityState.Added;
                _context.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public IEnumerable<Usuario> ShowAll()
        {
            var result = new List<Usuario>();
            try
            {
                result = _context.Usuario.OrderByDescending(x => x.id_usuario).ToList();
                
            }
            catch (Exception)
            {
                
            }
            return result;
        }
       
    }
}
