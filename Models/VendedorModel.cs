namespace CadastroVendedores.Models
{
    public class VendedorModel
    {
        internal string id;

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Clientes { get; set; }
    }
}
