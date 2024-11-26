using Core;
using Core.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
InicializadorBd.Inicializar();

builder.Services.AddScoped<IClienteService, ClienteService>();
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();


builder.Services.AddScoped<IOcorrenciaService, OcorrenciaService>();
builder.Services.AddScoped<IOcorrenciaRepository, OcorrenciaRepository>();
// Configuração do CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirTudo",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Permite requisições de qualquer origem (CORS)
app.UseCors("PermitirTudo");

app.UseAuthorization();

app.MapControllers();

app.Run();
