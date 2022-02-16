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
    public interface ITipoActividadService
    {
        bool Create(TipoActividad model);
        IEnumerable<TipoActividad> ShowAll();
    }
    public class TipoActividadService : ITipoActividadService
    {
        private readonly UsuarioDbContext _context;
        public TipoActividadService( UsuarioDbContext context)
        {
            _context = context;
        }
        public bool Create(TipoActividad model)
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

        public IEnumerable<TipoActividad> ShowAll()
        {
            var result = new List<TipoActividad>();
            try
            {
                result = _context.TipoActividad.OrderByDescending(x => x.id_tipo_actividad).ToList();
                
            }
            catch (Exception)
            {
                
            }
            return result;
        }
       
    }
}
