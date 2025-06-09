using System.ComponentModel.DataAnnotations;

namespace BlazorApp2.DTO
{
    public class CrearContribuyenteDTO
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "El nombre no debe superar los 50 caracteres")]
        public string Nombre { get; set; } = null!;
        [Required(ErrorMessage = "El rnc/cédula es obligatorio.")]
        [RegularExpression(@"^\d{9}(\d{2})?$", ErrorMessage = "Debe tener 9 o 11 dígitos numéricos.")]
        public string RncCedula { get; set; } = string.Empty;
        public int TipoId { get; set; }
        [Required(ErrorMessage = "El estatus es obligatorio")]
        public int EstatusId { get; set; }
    }
}
