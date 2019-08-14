using Microsoft.AspNetCore.Mvc;
using ProAcompanhamentoPedido.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProAcompanhamentoPedido.Controllers
{
    public class HomeController : Controller
    {

        private readonly AcompanhamentoContexto _context;

        public HomeController(AcompanhamentoContexto context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Pedido> pedidos = await _context.Pedidos.Include(p => p.Cliente).ToListAsync();
            return View(pedidos);
        }

    }
}
