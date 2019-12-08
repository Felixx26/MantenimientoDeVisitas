using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Web;

namespace MantenimientoVisitas.Models
{
    public class Visita
    {
        [Key]
        public int VisitaID { get; set; }

        [Required]
        [Display(Name = "Motivo de visita")]
        public string Motivo { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Visita")]
        public DateTime Fecha { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [Display(Name = "Hora de Entrada")]
        public TimeSpan HoraEntrada { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [Display(Name = "Hora de Salida")]
        public TimeSpan HoraSalida { get; set; }

        [Required]
        [Display(Name = "Visitante")]
        public int PersonaID { get; set; }
        public virtual Persona Persona { get; set; }

        [Required]
        [Display(Name = "Persona que le recibió")]
        public string Usuario { get; set; }
    }
}