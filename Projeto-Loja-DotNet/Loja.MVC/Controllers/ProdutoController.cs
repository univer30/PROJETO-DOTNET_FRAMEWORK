using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loja.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Loja.Application.ViewModels;

namespace Loja.MVC.Controllers
{
    public class ProdutoController : Controller
    {
        private IProdutoService _produtoService;
        public ProdutoController(IProdutoService  produtoService )
        {
          _produtoService = produtoService;
        }

        public IActionResult Index()
        {
            ProdutoViewModel model = _produtoService.GetProdutos();
            return View(model);

        }
    }
}