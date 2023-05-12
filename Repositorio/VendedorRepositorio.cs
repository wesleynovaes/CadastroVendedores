using CadastroVendedores.Data;
using CadastroVendedores.Models;
using System.Collections.Generic;
using System.Linq;

namespace CadastroVendedores.Repositorio
{
    public class VendedorRepositorio : IVendedorRepositorio
    {
        private readonly BancoContext _context;

        public VendedorRepositorio(BancoContext bancoContext)
        {
           this._context = bancoContext;
        }

        public VendedorModel ListarPorId(int id)
        {
            return _context.Vendedores.FirstOrDefault(x => x.Id == id);
        }

        public List<VendedorModel> BuscarTodos()
        {
            return _context.Vendedores.ToList();
        }

        public VendedorModel Adicionar(VendedorModel vendedor)
        {
            _context.Vendedores.Add(vendedor);
            _context.SaveChanges();
            return vendedor;
        }

        public VendedorModel Atualizar(VendedorModel vendedor)
        {
            VendedorModel vendedorDB = ListarPorId(vendedor.Id);

            if (vendedorDB == null) throw new System.Exception("Houve um erro na atualização do vendedor");

            vendedorDB.Nome = vendedor.Nome;
            vendedorDB.Cpf = vendedor.Cpf;
            vendedorDB.Email = vendedor.Email;
            vendedorDB.Celular = vendedor.Celular;
            vendedorDB.Clientes = vendedor.Clientes;

            _context.Vendedores.Update(vendedorDB);
            _context.SaveChanges();

            return vendedorDB;
        }
    }
}
