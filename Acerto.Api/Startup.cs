namespace Acerto.Api
{
    public class Startup
    {
        private readonly IConfiguration _configuration; //pega as configuration de arquivos de setting
        private readonly IServiceCollection _services;

        public Startup(WebApplicationBuilder builder)
        {
            _configuration = builder.Configuration;
            _services = builder.Services;
        }

        public void ConfigureServices()
        {
            // Add services to the container.

            _services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            _services.AddEndpointsApiExplorer();
            _services.AddSwaggerGen();
        }


        //processa td mundo que é aplication

        public void ConfigureAplication(IApplicationBuilder app)
        {
            // Configure the HTTP request pipeline.
            app.UseSwagger();
            app.UseSwaggerUI();
            

            app.UseHttpsRedirection(); //redireciona as url pra https que é mais seguro
            app.UseRouting();
            app.UseAuthorization(); //verifica se precisa de login
                                    //configuramos [Authorization] na controller pra acessar os endpoint com login
            app.UseEndpoints(options => options.MapControllers());
        }

    }
}
