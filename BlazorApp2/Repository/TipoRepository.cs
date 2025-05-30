using BlazorApp2.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Repository
{
    public class TipoRepository : ITipoRepository
    {
        private readonly ApplicationDbContext context;
        public TipoRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Tipo>> Listar()
        {
            return await context.Tipos.ToListAsync();
        }

        public async Task<Tipo> Agregar(Tipo tipo)
        {
            context.Add(tipo);
            await context.SaveChangesAsync();
            return tipo;
        }

        public async Task<Tipo> Eliminar(Tipo tipo)
        {
            context.Remove(tipo);
            await context.SaveChangesAsync();
            return tipo;
        }
    }
}
