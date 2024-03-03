using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Infraestructure
{
    public class SixXDbContext : DbContext
    {
        public DbSet<Endereco> Enderecos { get; set; }

        public SixXDbContext(DbContextOptions options) : base(options) { }
    }
}