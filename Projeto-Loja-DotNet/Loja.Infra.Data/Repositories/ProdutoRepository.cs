using Loja.Domain.Interfaces;
using Loja.Domain.Models;
using Loja.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.Infra.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        public LojaDbContext _context;

        public ProdutoRepository(LojaDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Produto> GetProdutos(){
            return _context.Produtos;
        }
    }
}

