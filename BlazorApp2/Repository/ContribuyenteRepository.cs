using BlazorApp2.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Repository
{
    public class ContribuyenteRepository : IContribuyenteRepository
    {
        private readonly ApplicationDbContext context;
        public ContribuyenteRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<Contribuyente> Agregar(Contribuyente contribuyente)
        {
            context.Add(contribuyente);
            await context.SaveChangesAsync();
            return contribuyente;
        }

        public async Task<Contribuyente> Eliminar(Contribuyente contribuyente)
        {
            context.Remove(contribuyente);
            await context.SaveChangesAsync();
            return contribuyente;
        }

        public async Task<List<Contribuyente>> Listar()
        {
            return await context
                .Contribuyentes
                .Include(t => t.Tipo)
                .Include(e => e.Estatus)
                .ToListAsync();
        }
    }
}
