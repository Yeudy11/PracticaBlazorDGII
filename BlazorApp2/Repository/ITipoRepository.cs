using BlazorApp2.Entities;

namespace BlazorApp2.Repository
{
    public interface ITipoRepository
    {
        Task<List<Tipo>> Listar();
        Task<Tipo> Agregar(Tipo tipo);
        Task<Tipo> Eliminar(Tipo tipo);
    }
}
