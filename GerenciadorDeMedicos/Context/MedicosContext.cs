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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-1N95O0N; Database=GerenciadorDeMedicos;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Medico>(entity =>
            {
                entity
                .HasIndex(M => M.Id)
                .IsUnique();

                entity.HasData(
                new Medico
                {
                    Id = 1,
                    Nome = "Giovana Dias Carvalho",
                    Cpf = "776.077.220-33",
                    Crm = "2510-SC",
                });
            });
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity
                .HasIndex(U => U.Id)
                .IsUnique();

                entity
                .HasData(
                new Usuario
                {
                    Id = 1,
                    Email = "user@user.com",
                    Senha = "user",
                });
            });
            base.OnModelCreating(modelBuilder);
        }
    } 
}
