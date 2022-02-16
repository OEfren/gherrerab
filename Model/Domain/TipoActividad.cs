﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Domain
{
    public class TipoActividad
    {
        [Key]
        public int id_tipo_actividad { get; set; }
        [Column(TypeName = "varchar(50)"), Required]
        public string tipo_actividad { get; set; }
        
    }
}
