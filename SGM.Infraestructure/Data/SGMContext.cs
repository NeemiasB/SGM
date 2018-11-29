using Microsoft.EntityFrameworkCore;
using SGM.ApplicationCore;
using SGM.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGM.Infraestructure.Data
{
   public class SGMContext : DbContext
    {

        public SGMContext()
        {


        }

    public DbSet<Multa> Multas { get; set; }
    public DbSet<Veiculo> Veiculos { get; set; }
    public DbSet<Marca> Marcas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BdSGM;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Multa>().ToTable("TbInfração");
            modelBuilder.Entity<Veiculo>().ToTable("TbVeiculos");
            modelBuilder.Entity<Marca>().ToTable("TbMarcas");
        }


    }
  }