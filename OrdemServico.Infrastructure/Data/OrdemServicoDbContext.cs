using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrdemServico.Domain.Entities;

namespace OrdemServico.Infrastructure.Data
{
    public class OrdemServicoDbContext : DbContext
    {
        public OrdemServicoDbContext(DbContextOptions<OrdemServicoDbContext> options) : base(options)
        {

        }
        
        public DbSet<Servico> Servicos { get; set; }
    }
}