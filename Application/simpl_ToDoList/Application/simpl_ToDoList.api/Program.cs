using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Internal;
using simpl_ToDoList.Data.Context.Contrat;
using simpl_ToDoList.Data.Repository;
using simpl_ToDoList.Data.Repository.Contrat;
using Simpl_ToDoList.Business.Service;
using Simpl_ToDoList.Business.Service.Contrat;
using simpl_ToDoListe.Data.Context;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


string connectionString = builder.Configuration.GetConnectionString("BddConnection");

builder.Services.AddDbContext<Isimpl_ToDoListDBContect,simpl_ToDoListDBContect>
    (options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString),
                mySqlOptions =>
                {
                    mySqlOptions.MigrationsAssembly("simpl_ToDoList.api");
                })
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors());

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddAutoMapper(Assembly.Load("Simpl_ToDoList.Business.Mapper"));

//injection
builder.Services.AddScoped<ITachesRepository, TachesRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ITachesRepository, TachesRepository>();

builder.Services.AddScoped<ITachesService, TachesService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
