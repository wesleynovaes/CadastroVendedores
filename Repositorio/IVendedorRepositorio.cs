using CadastroVendedores.Models;
using System.Collections.Generic;

namespace CadastroVendedores.Repositorio
{
    public interface IVendedorRepositorio
    {
        VendedorModel ListarPorId(int id);
        List<VendedorModel> BuscarTodos();
        VendedorModel Adicionar(VendedorModel vendedor);
        VendedorModel Atualizar(VendedorModel vendedor);
    }
}