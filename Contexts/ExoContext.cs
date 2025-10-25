using Exo.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace Exo.WebApi.Contexts
{
    
    public class ExoContext : DbContext
    {
        public ExoContext() { }

        public ExoContext(DbContextOptions<ExoContext> options) : base(options) { }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                // estabelece a string de conexão com o banco de dados SQL Server
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;" + "Database=ExoApi;Trusted_Connection=True;");
                
                // Exemplo 2 de string de conexão para SQL Server com autenticação SQL
                // optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;" + "Database=ExoApi;User Id=seu_usuario;Password=sua_senha;");

                // Exemplo 3 de string de conexão para SQL Server com autenticação SQL
                // User Id=sa;Password=admin;Server=localhost;Database=ExoApi; + Trusted_Connection=False;
            }
        }
        public DbSet<Projeto> Projetos { get; set; }

         public DbSet<Usuario> Usuarios { get; set; }
    
    }
}