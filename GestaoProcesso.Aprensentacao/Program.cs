using GestaoProcesso.Aprensentacao.Extensions;

var builder = WebApplication.CreateBuilder(args);


builder.Services.ConfigureControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureCors();

string connectionSrting = builder.Configuration.GetConnectionString("Mysql");
builder.Services.ConfigureDatabase(connectionSrting);


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
