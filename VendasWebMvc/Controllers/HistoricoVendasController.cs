using Microsoft.AspNetCore.Mvc;
using VendasWebMvc.Services;

namespace VendasWebMvc.Controllers
{
    public class HistoricoVendasController : Controller
    {
        private readonly HistoricoVendasService _historicoVendasService;

        public HistoricoVendasController(HistoricoVendasService historicoVendasService)
        {
            _historicoVendasService = historicoVendasService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> BuscaSimples(DateTime? minDate, DateTime? maxDate)
        {
            if(!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }

            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }

            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");
            var resultado = await _historicoVendasService.FindByDateAsync(minDate, maxDate);
            return View(resultado);
        }

        public IActionResult BuscaAgrupada()
        {
            return View();
        }
    }
}
