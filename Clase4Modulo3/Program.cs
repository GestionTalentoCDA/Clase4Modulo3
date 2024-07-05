using Clase4Modulo3.Extensions;
using Clase4Modulo3.Middlewares;
using Clase4Modulo3.Repository;
using Clase4Modulo3.Services;
using Clase4Modulo3.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Clase4Modulo3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            builder.Services.AddDependenciasCustom(builder.Configuration);



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


            app.UseMiddleware<GlobalExceptionHandler>();

            app.Run();
        }
    }
}