using CadastroVendedores.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroVendedores.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<VendedorModel> Vendedores { get; set; }
    }
}
