using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager4.Models
{
    public class ActividadViewModel
    {
        [Required]
        public int id_creador { get; set; }
        [Required]
        public int id_tipo_actividad { get; set; }
        [Required]
        public int id_asignado { get; set; }
        [Required]
        public int id_asignador { get; set; }
        [Required]
        public string actividad { get; set; }
        public DateTime fecha_inicial { get; set; }

        public string detalle { get; set; }

        public bool finalizada { get; set; }
    }
}
