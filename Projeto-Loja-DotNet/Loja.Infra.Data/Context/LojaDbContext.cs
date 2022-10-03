using Loja.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.Infra.Data.Context
{
    public class LojaDbContext : DbContext
    {
        public LojaDbContext(DbContextOptions<LojaDbContext> options)
            : base(options) { }

        public DbSet<LojaMarilia> LojaMarilias {get; set;}
        public DbSet<Produto> Produtos {get; set;}
    }
}