using System.ComponentModel.DataAnnotations;

namespace EventEaseApp.Shared
{
    public class EventModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder 100 caracteres.")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "La fecha es obligatoria.")]
        [CustomValidation(typeof(EventModel), "ValidateFecha")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "La ubicación es obligatoria.")]
        [StringLength(200, ErrorMessage = "La ubicación no puede exceder 200 caracteres.")]
        public string Ubicacion { get; set; } = string.Empty;

        public static ValidationResult ValidateFecha(DateTime fecha, ValidationContext context)
        {
            if (fecha.Date < DateTime.Today)
                return new ValidationResult("La fecha debe ser hoy o en el futuro.");
            return ValidationResult.Success;
        }
    }
}
