using Loja.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.Application.Interfaces
{
    public interface IProdutoService
    {
        ProdutoViewModel GetProdutos();
        
    }
}