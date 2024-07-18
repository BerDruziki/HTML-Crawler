using Microsoft.EntityFrameworkCore;

namespace DbPgSql
{
    public class pgsql : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=seu host;Database=nome do banco;User Id=nome do user;Port=porta;Password=senhas;");

    }
}