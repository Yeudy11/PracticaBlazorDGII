using BlazorApp2.Entities;

namespace BlazorApp2.Repository
{
    public interface IEstatusRepository
    {
        Task<List<Estatus>> Listar();
        Task<Estatus> Agregar(Estatus estatus);
        Task<Estatus> Eliminar(Estatus estatus);
    }
}
