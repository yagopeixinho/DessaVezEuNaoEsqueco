using DessaVezEuNaoEsquecoAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Configuração do banco de dados
builder.Services.AddDbContext<DessaVezEuNaoEsquecoContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Configuração do Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "DessaVezEuNaoEsqueco API", Version = "v1" });
});

// Adicionar serviço de controllers
builder.Services.AddControllers();

var app = builder.Build();

// Middleware de desenvolvimento para Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Minha API v1");
    });
}

// Middleware para redirecionamento HTTPS
app.UseHttpsRedirection();

// Define os endpoints da API
app.MapControllers();

app.Run();