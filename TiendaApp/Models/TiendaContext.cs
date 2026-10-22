using System;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace TiendaApp.Models
{
    public class TiendaContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string dbPath = Path.Combine(baseDir, "TiendaDB.mdf");

            string conexion = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                              "AttachDbFilename=" + dbPath + ";" +
                              "Integrated Security=True;" +
                              "TrustServerCertificate=True";

            optionsBuilder.UseSqlServer(conexion);
        }
    }
}