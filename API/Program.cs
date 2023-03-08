using API.Configuration;
using API.Data;
using API.Data.Repository;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);
//string connectionString = "Server=localhost,3306;Database=restaurante;user=root;password=toor";
//var serverVersion = ServerVersion.AutoDetect(connectionString);


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
//builder.Services.AddDbContext<MyContext>(
//            dbContextOptions => dbContextOptions
//                .UseMySql(connectionString, serverVersion)
//                .LogTo(Console.WriteLine, LogLevel.Information)
//                .EnableSensitiveDataLogging()
//                .EnableDetailedErrors()
//        );

builder.Services.AddInjectionConfig();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    //app.UseSwaggerUI();
    app.UseSwaggerUI(s => s.SwaggerEndpoint("/swagger/PruebaPractica/swagger.json", "Prueba"));

}

app.UseHttpsRedirection();

app.UseCors(policy => policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.UseAuthorization();

app.MapControllers();

app.Run();
