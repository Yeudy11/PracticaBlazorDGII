namespace BlazorApp2.Entities
{
    public class Estatus
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Contribuyente> Contribuyentes { get; set; } = new List<Contribuyente>();
    }
}
