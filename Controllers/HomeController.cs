using Microsoft.AspNetCore.Mvc;
using ProAcompanhamentoPedido.Dao;
using ProAcompanhamentoPedido.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProAcompanhamentoPedido.Controllers
{
    public class HomeController : Controller
    {

        PedidoRepository _pedidoRepository;
        private readonly AcompanhamentoContexto _context;

        public HomeController(PedidoRepository pedidoRepository, AcompanhamentoContexto context)
        {
            _pedidoRepository = pedidoRepository;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            //List<PedidoCliente> pedidos = await _context.PedidoClientes.Include(p =>p.Cliente).ToListAsync();

            return View();
        }

        public async Task<IActionResult> Teste()
        {
            List<PedidoCliente> pedidos = await _context.PedidoClientes.Include(p => p.Cliente).ToListAsync();
            return View(pedidos);
        }

        public IActionResult Slide()
        {
            return View();
        }

    }
}
