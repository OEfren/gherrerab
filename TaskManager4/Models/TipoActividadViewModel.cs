using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager4.Models
{
    public class TipoActividadViewModel
    {
        [Required]
        public string tipo_actividad { get; set; }
    }
}
