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
    public interface IActividadService
    {
        bool Create(Actividad model);
        IEnumerable<Actividad> ShowAll();
    }
    public class ActividadService : IActividadService
    {
        private readonly UsuarioDbContext _context;
        public ActividadService( UsuarioDbContext context)
        {
            _context = context;
        }
        public bool Create(Actividad model)
        {
            try
            {
                model.fecha_final = DateTime.Now;
                _context.Entry(model).State = EntityState.Added;
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<Actividad> ShowAll()
        {
            var result = new List<Actividad>();
            try
            {
                result = _context.Actividad.OrderByDescending(x => x.id_actividad ).ToList();

            }
            catch (Exception)
            {

            }
            return result;
        }

    }
}

