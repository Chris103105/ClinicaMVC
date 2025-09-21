using System.ComponentModel.DataAnnotations;

namespace ClinicaMVC.Models
{
    public class Medico
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La especialidad es obligatoria.")]
        [StringLength(100)]
        public string Especialidad { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio.")]
        [Phone(ErrorMessage = "Formato de teléfono no válido.")]
        public string Telefono { get; set; }
    }
}