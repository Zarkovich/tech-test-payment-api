using tech_test_payment_api.Models;

namespace tech_test_payment_api.Context
{
    public static class VendasContext
    {
        static List<Venda> Vendas = new();


        public static void AdicionarVenda(Venda venda)
        {
            Vendas.Add(venda);
        }

        public static void AtualizarStatus(Venda venda, int id)
        {
            var VendaPut = Vendas.Find(x => x.IdVenda == id);
            VendaPut.Status = venda.Status;
        }

        public static List<Venda> TotalVendas()
        {
            return Vendas;
        }
    }
}