using GerenciadorDeMedicos.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeMedicos.Context
{
    public class MedicosContext : DbContext
    {
        public DbSet<Medico> Medico { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Especialidade> Especialidade { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-1N95O0N; Database=GerenciadorDeMedicos;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Especialidade>(entity =>
            {
                entity
                .HasIndex(E => E.Id)
                .IsUnique();
            });        
            modelBuilder.Entity<Medico>(entity =>
            {
                entity
                .HasIndex(M => M.Id)
                .IsUnique();
            });
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity
                .HasIndex(U => U.Id)
                .IsUnique();
            });
            base.OnModelCreating(modelBuilder);
        }
    } 
}
