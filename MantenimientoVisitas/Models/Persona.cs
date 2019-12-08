using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MantenimientoVisitas.Models
{
    public class Persona
    {
        [Key]
        [Required]
        public int PersonaID { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Required]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }
        [Required]
        [Display(Name = "Cédula/Pasaporte")]
        public string Identificacion { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name ="Fecha de Creación")]
        public DateTime Fecha { get; set; }

    }
}