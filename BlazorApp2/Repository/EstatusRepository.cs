using BlazorApp2.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Repository
{
    public class EstatusRepository : IEstatusRepository
    {
        private readonly ApplicationDbContext context;
        public EstatusRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Estatus>> Listar()
        {
            return await context.Estatuses.ToListAsync();
        }

        public async Task<Estatus> Agregar(Estatus estatus)
        {
            context.Add(estatus);
            await context.SaveChangesAsync();
            return estatus;
        }

        public async Task<Estatus> Eliminar(Estatus estatus)
        {
            context.Remove(estatus);
            await context.SaveChangesAsync();
            return estatus;
        }
    }
}
