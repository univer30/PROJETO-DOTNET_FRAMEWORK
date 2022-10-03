using Loja.Application.Interfaces;
using Loja.Application.ViewModels;
using Loja.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.Application.Services
{
public class ProdutoService :IProdutoService
{
    public IProdutoRepository _produtoRepository;

    public ProdutoService(IProdutoRepository produtoRepository)
    {
         _produtoRepository = produtoRepository;
    }
     public ProdutoViewModel GetProdutos()
        {
            return new ProdutoViewModel()
            {
              Produtos = _produtoRepository.GetProdutos()
            };
        }
}
}