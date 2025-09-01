using OrdemServico.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using OrdemServico.Application.Services;
using OrdemServico.Application.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IServicoService, ServicoService>();

builder.Services.AddDbContext<OrdemServicoDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao")));

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


