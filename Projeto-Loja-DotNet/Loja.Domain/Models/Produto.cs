using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.Domain.Models
{
    public class Produto
    {

        public int Id {get; set;}
        public string nome {get; set;}
        public double preco {get; set;}
        public int qtde {get; set;}

        public virtual LojaMarilia LojaMarilia {get; set;}

    } 
}