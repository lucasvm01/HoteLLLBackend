using HoteLLLBackend.Domain.Entities.Hospedagens;
using HoteLLLBackend.Domain.Entities.Pessoas;
using HoteLLLBackend.Domain.Entities.Quartos;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace HoteLLLBackend.Infra.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Quarto> Quartos { get; set; }
        public DbSet<Hospedagem> Hospedagens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Pessoa>().HasKey(p => p.Id);
            modelBuilder.Entity<Quarto>().HasKey(q => q.Id);
            modelBuilder.Entity<Hospedagem>().HasKey(h => h.Id);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Server=localhost;Database=master;Trusted_Connection=False;TrustServerCertificate=True;Integrated Security=True");
    }
}
