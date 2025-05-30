using System.ComponentModel.DataAnnotations;

namespace BlazorApp2.Entities
{
    public class Contribuyente
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string RncCedula { get; set; } = string.Empty;
        public int TipoId { get; set; }
        public Tipo Tipo { get; set; }
        public int EstatusId { get; set; }
        public Estatus Estatus { get; set; }
    }
}
