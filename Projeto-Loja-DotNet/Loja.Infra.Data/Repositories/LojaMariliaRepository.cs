using Loja.Domain.Interfaces;
using Loja.Domain.Models;
using Loja.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.Infra.Data.Repositories
{
    public class LojaMariliaRepository : ILojaMariliaRepository
    {

       public LojaDbContext _context;
       
       public LojaMariliaRepository(LojaDbContext context)
        {
            _context = context;
        }
        public IEnumerable<LojaMarilia> GetLojaMarilias(){
            return _context.LojaMarilias;
        }
    }
}

