using System.ComponentModel.DataAnnotations;

namespace BlazorApp2.Entities
{
    public class Contribuyente
    {
        [Required(ErrorMessage = "Nombre es obligatorio")]
        public string Nombre { get; set; } = "";

        [Required(ErrorMessage = "RncCedula obligatorio")]
        public string RncCedula { get; set; } = "";

        [Required(ErrorMessage = "Tipo es obligatorio")]
        public string Tipo { get; set; } = "";

        [Required(ErrorMessage = "Estatus es obligatorio")]
        public string Estatus { get; set; } = "";
    }
}
