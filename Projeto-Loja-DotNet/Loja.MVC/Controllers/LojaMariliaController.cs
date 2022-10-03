using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loja.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Loja.Application.ViewModels;

namespace Loja.MVC.Controllers
{
    public class LojaMariliaController : Controller
    {
        private ILojaMariliaService _LojaMariliaService;
        public LojaMariliaController(ILojaMariliaService LojaMariliaService )
        {
          _LojaMariliaService = LojaMariliaService;
        }

        public IActionResult Index()
        {
            LojaMariliaViewModel model = _LojaMariliaService.GetLojaMarilias();
            return View(model);

        }
    }
}