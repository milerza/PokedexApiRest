using Acerto.Api;

var builder = WebApplication.CreateBuilder(args); //construtor da aplicacao
var startup = new Startup(builder);

startup.ConfigureServices();

var app = builder.Build();

startup.ConfigureAplication(app);

app.Run();
