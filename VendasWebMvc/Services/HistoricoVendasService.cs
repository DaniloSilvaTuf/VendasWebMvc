using Microsoft.EntityFrameworkCore;
using VendasWebMvc.Data;
using VendasWebMvc.Models;

namespace VendasWebMvc.Services
{
    public class HistoricoVendasService
    {
        private readonly VendasWebMvcContext _context;

        public HistoricoVendasService(VendasWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<HistoricoVendas>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var resultado = from obj in _context.HistoricoVendas select obj;
            if(minDate.HasValue)
            {
                resultado = resultado.Where(x => x.Data >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                resultado = resultado.Where(x => x.Data <= maxDate.Value);
            }
            return await resultado
                .Include(x => x.Vendedor)
                .Include(x => x.Vendedor.Departamento)
                .OrderByDescending(x => x.Data)
                .ToListAsync();
        }
    }
}
