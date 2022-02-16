using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager4.Models
{
    public class UsuarioViewModel
    {
        [Required]
        public string usuario { get; set; }
        [Required]
        public int tipo_usuario { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public string apellidos { get; set; }
    }
}
