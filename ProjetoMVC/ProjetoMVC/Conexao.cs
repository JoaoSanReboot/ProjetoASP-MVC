using Microsoft.EntityFrameworkCore;
using ProjetoMVC.Data;

namespace ProjetoMVC
{
    public class Conexao
    {

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddEntityFrameworkSqlServer()
                .AddDbContext<BancoContext>(o => o.UseSqlServer(Configuration.GetConnectionString("DataBase")));
        }
    }
}
