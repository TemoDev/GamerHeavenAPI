using GamerHeavenAPI.Models.DbContexts;
using GamerHeavenAPI.Models.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace GamerHeavenAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddScoped<IConsoleRepository, ConsoleRepository>();
            builder.Services.AddScoped<ITransactionRepository, TransactionRepository>();
            builder.Services.AddScoped<IControllerRepository, ControllerRepository>();

            builder.Services.AddControllers()
                .AddJsonOptions(s => s.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);


            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<GamerHeavenDbContext>(
                c => c.UseSqlServer(builder.Configuration["ConnectionStrings:GamerHeavenAPIString"])
            );

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
        }
    }
}