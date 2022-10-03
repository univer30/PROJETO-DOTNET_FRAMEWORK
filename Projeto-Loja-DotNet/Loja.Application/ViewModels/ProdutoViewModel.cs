using Loja.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.Application.ViewModels
{
    public class ProdutoViewModel
    {
        public IEnumerable<Produto> Produtos {get; set;}
    }
}