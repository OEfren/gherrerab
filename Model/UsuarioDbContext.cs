using Microsoft.EntityFrameworkCore;
using Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UsuarioDbContext : DbContext
    {
        public UsuarioDbContext(DbContextOptions<UsuarioDbContext> options)
            : base(options)
        {

        }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<TipoActividad> TipoActividad { get; set; }
        public DbSet<Actividad> Actividad { get; set; }

    }
}