using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using ProjetoMVC.Data;

namespace ProjetoMVC
{
    public class Conexao
    {
        public class BancoContextFactory : IDesignTimeDbContextFactory<BancoContext>
        {
            public BancoContext CreateDbContext(string[] args)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                var optionsBuilder = new DbContextOptionsBuilder<BancoContext>();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DataBase"));

                return new BancoContext(optionsBuilder.Options);
            }
        }

    }
}
