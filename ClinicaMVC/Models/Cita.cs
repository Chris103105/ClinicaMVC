using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicaMVC.Models
{
    public class Cita
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La fecha de la cita es obligatoria.")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha de la Cita")]
        public DateTime FechaCita { get; set; }

        [Required(ErrorMessage = "El motivo es obligatorio.")]
        public string Motivo { get; set; }

        // Claves foráneas
        [Display(Name = "Paciente")]
        public int PacienteId { get; set; }
        [ForeignKey("PacienteId")]
        public Paciente Paciente { get; set; }

        [Display(Name = "Médico")]
        public int MedicoId { get; set; }
        [ForeignKey("MedicoId")]
        public Medico Medico { get; set; }
    }
}