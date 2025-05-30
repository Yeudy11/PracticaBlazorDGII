namespace BlazorApp2.Entities
{
    public class Tipo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Contribuyente> Contribuyentes { get; set; } = new List<Contribuyente>();
    }
}
