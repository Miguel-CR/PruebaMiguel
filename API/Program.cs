using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(s => s.SwaggerDoc("PruebaPractica", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Prueba", Version = "v1" }));
builder.Services.AddDbContext<MyContext>(options =>
{
    options.UseMySQL(builder.Configuration.GetConnectionString("Default"));
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    //app.UseSwaggerUI();
    app.UseSwaggerUI(s => s.SwaggerEndpoint("/swagger/PruebaPractica/swagger.json", "Prueba"));

}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
