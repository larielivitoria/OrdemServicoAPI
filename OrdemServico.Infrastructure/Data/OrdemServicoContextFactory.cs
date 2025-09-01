using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace OrdemServico.Infrastructure.Data
{
    public class OrdemServicoContextFactory : IDesignTimeDbContextFactory<OrdemServicoDbContext>
    {
        public OrdemServicoDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<OrdemServicoDbContext>();

            optionsBuilder.UseSqlServer("Server=localhost\\sqlexpress; Initial Catalog=OrdemServico;Integrated Security=True;TrustServerCertificate=True;");

            return new OrdemServicoDbContext(optionsBuilder.Options);
        }
    }
     
}