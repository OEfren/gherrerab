using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Domain
{
    public class Usuario
    {
        [Key]
        public int id_usuario { get; set; }
        [Column (TypeName = "varchar(50)"), Required]
        public string usuario { get; set; }
        [Required]
        public int tipo_usuario { get; set; }
        [Column(TypeName = "varchar(50)"), Required]
        public string password { get; set; }
        [Column(TypeName = "varchar(50)"), Required]
        public string nombre { get; set; }
        [Column(TypeName = "varchar(100)"), Required]
        public string apellidos { get; set; }
       


    }
}
