using Microsoft.EntityFrameworkCore;
using ScaleupFinance.Assesment.Business;
using ScaleupFinance.Assessment.Data;

namespace ScaleupFinance.Assessment.API
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDataLayer();
            builder.Services.AddBusinessLayer();
            builder.Services.AddDbContext<ProductDbContext>(opt => opt.UseInMemoryDatabase("products"));

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            using var scope = app.Services.CreateScope();
            var context = scope.ServiceProvider.GetService<ProductDbContext>();
            context.Brands.Add(new Data.Models.Brand
            {
                Name = "Nike"
            });
            context.Brands.Add(new Data.Models.Brand
            {
                Name = "Adidas"
            });
            context.Brands.Add(new Data.Models.Brand
            {
                Name = "Converse"
            });
            await context.SaveChangesAsync();
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