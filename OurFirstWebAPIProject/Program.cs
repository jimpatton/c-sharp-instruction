using Microsoft.EntityFrameworkCore;
using OurFirstWebAPIProject.Models;

namespace OurFirstWebAPIProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers().AddJsonOptions(opt => {
                opt.JsonSerializerOptions.ReferenceHandler =
                  System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
            });
            builder.Services.AddDbContext<BMDBContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("BmdbConnectionString"))
                );

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseStaticFiles();

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
