using GestaoProcesso.Aplicacao.Hubs;
using GestaoProcesso.Aprensentacao.Extensions;
using GestaoProcessos.Infraestrutura.CrossCutting.IoC;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureCors();
builder.Services.ConfigureAutoMapper();
builder.Services.RegisterModules();

builder.Services.AddSignalR();

string connectionSrting = builder.Configuration.GetConnectionString("Mysql");
builder.Services.ConfigureDatabase(connectionSrting);


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();
app.UseCors("corsWebsocket");
app.UseCors("corsapp");
app.UseHttpsRedirection();
app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapHub<ChamadoHub>("/chamado");
});

app.Run();
