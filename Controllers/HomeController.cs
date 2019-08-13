using Microsoft.AspNetCore.Mvc;
using ProAcompanhamentoPedido.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAcompanhamentoPedido.Controllers
{
    public class HomeController : Controller
    {

        PedidoRepository _pedidoRepository;

        public HomeController(PedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        public IActionResult Index()
        {
            return View(_pedidoRepository.Pedidos);
        }

        public IActionResult Slide()
        {
            return View();
        }

    }
}
