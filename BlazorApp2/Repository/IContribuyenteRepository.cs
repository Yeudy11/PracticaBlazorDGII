using BlazorApp2.Entities;

namespace BlazorApp2.Repository
{
    public interface IContribuyenteRepository
    {
        Task<List<Contribuyente>> Listar();
        Task<Contribuyente> Agregar(Contribuyente contribuyente);
        Task<Contribuyente> Eliminar(Contribuyente contribuyente);
    }
}
