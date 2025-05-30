using System.ComponentModel.DataAnnotations;

namespace BlazorApp2.DTO
{
    public class CrearTipoDTO
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "El nombre no debe superar los 50 caracteres")]
        public string Nombre { get; set; } = null!;
    }
}
