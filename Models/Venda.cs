

namespace tech_test_payment_api.Models
{
    public class Venda
    {
        public int IdVenda { get; } = new Random().Next();
        public Vendedor Vendedor { get; set; }
        public DateTime Data { get; set; }
        public string[] Itens { get; set; }

    }
}