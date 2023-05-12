using CadastroVendedores.Models;
using CadastroVendedores.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CadastroVendedores.Controllers
{
    public class VendedorController : Controller
    {

        private readonly IVendedorRepositorio _vendedorRepositorio;

        public VendedorController(IVendedorRepositorio vendedorRepositorio)
        {
            _vendedorRepositorio = vendedorRepositorio;
        }

        public IActionResult Index()
        {
            List<VendedorModel> vendedor = _vendedorRepositorio.BuscarTodos();

            return View(vendedor);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Clientes()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            VendedorModel vendedor = _vendedorRepositorio.ListarPorId(id);
            return View(vendedor);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            VendedorModel vendedor = _vendedorRepositorio.ListarPorId(id);
            return View(vendedor);
        }

        [HttpPost]
        public IActionResult Criar(VendedorModel vendedor)
        {
            _vendedorRepositorio.Adicionar(vendedor);
            return RedirectToAction("index");
        }

        [HttpPost]
        public IActionResult Alterar(VendedorModel vendedor)
        {
            _vendedorRepositorio.Atualizar(vendedor);
            return RedirectToAction("index");
        }
    }
}
