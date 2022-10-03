using Loja.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.Domain.Interfaces
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> GetProdutos();
    }
}