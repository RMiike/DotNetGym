using DNG.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace DNG.API.Persistence
{
    public class DNGDbContext : DbContext
    {
        public DNGDbContext(DbContextOptions<DNGDbContext> opt) : base(opt)
        {

        }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Unidade> Unidades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Professor>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Unidade>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Unidade>()
                .HasMany(x => x.Alunos)
                .WithOne(x => x.Unidade)
                .HasForeignKey(x => x.IdUnidade)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Unidade>()
                .HasMany(x => x.Professores)
                .WithOne(x => x.Unidade)
                .HasForeignKey(x => x.IdUnidade)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Professor>()
                 .HasMany(x => x.Alunos)
                 .WithOne(x => x.Professor)
                 .HasForeignKey(x => x.IdProfessor)
                 .OnDelete(DeleteBehavior.Restrict);
        }
    }
}