using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Domain
{
    public class Actividad
    {
        
      
        [Key]
        public int id_actividad { get; set; }
        [Required]
        public int id_creador { get; set; }
        [Required]
        public int id_tipo_actividad { get; set; }
        [Required]
        public int id_asignado { get; set; }
        [Required]
        public int id_asignador { get; set; }
        [Required]
        public DateTime fecha_inicial { get; set; }
        [Required]
        public string actividad { get; set; }

        public string detalle { get; set; }


        public DateTime fecha_final { get; set; }


        public bool finalizada { get; set; }

    }
}
