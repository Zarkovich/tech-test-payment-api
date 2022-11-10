using Microsoft.AspNetCore.Mvc;
using tech_test_payment_api.Models;
using tech_test_payment_api.Context;

namespace tech_test_payment_api.Controllers
{
    [ApiController]
    [Route("venda")]
    public class VendaController : ControllerBase
    {
        [HttpPost]
        public IActionResult AdicionarVenda(Venda venda)
        {
            VendasContext.AdicionarVenda(venda);

            return Ok(venda);
        }

        [HttpGet("TotalVendas")]
        public IActionResult TotalVendas()
        {
            var venda = VendasContext.TotalVendas();
            return Ok(venda);
        }
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            var venda = VendasContext.TotalVendas().Where(x => x.IdVenda == id);


            return Ok(venda);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarStatus(int id, string newStatus)
        {

            var venda = VendasContext.TotalVendas().Find(x => x.IdVenda == id);

            if (venda.Status == "Entregue") return Ok(venda);

            if (newStatus == null || newStatus == "") venda.Status = "att";

            else
                venda.Status = newStatus;

            return Ok(venda);
        }
    }
}