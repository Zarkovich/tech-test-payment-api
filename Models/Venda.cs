

namespace tech_test_payment_api.Models
{
    public class Venda
    {
        int x = 0;
        string _status;
        public int IdVenda { get; } = new Random().Next();
        public Vendedor Vendedor { get; set; }
        public DateTime Data { get; }
        public string[] Itens { get; set; }
        public string Status
        {
            get => _status;

            set
            {
                if (value.ToLower() == "cancelado") _status = "Cancelado";

                else
                    _status = StatusVenda.Status[x++];
            }
        }

    }
}