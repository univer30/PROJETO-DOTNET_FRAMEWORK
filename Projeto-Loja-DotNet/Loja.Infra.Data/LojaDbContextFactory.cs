using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Loja.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Loja.Infra.Data
{
    public class LojaDbContextFactory 
        : IDesignTimeDbContextFactory<LojaDbContext>
    {
        public LojaDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LojaDbContext>();
            optionsBuilder.UseSqlite("Data Source=loja.db");

            return new LojaDbContext(optionsBuilder.Options);
        }
    }
}