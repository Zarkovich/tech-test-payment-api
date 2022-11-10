

namespace tech_test_payment_api.Models
{
    public class Vendedor
    {
        public int Id { get; } = new Random().Next();
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}