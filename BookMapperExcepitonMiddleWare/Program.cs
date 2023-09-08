using BookMapperExcepitonMiddleware.Middlewares;
using BookMapperExcepitonMiddleWare.Data;
using BookMapperExcepitonMiddleWare.Repositories;
using BookMapperExcepitonMiddleWare.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BookMapperExcepitonMiddleWare
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            

            // Add services to the container.
            builder.Services.AddScoped<IBookRepository, BookRepository>();
            builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();

            builder.Services.AddTransient<CustomExceptionMiddleware>();
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            
            options.UseSqlServer(builder.Configuration.GetConnectionString("Database")));

            // ignore looping

            builder.Services.AddAutoMapper(typeof(Program));
            var app = builder.Build();

            app.UseMiddleware<CustomExceptionMiddleware>();

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