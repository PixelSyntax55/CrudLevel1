using Crud_Level_1.NAME.DTOS.OGDTO;
using Crud_Level_1.NAME.DTOS.ServiceLayer;
using Crud_Level_1.NAME.RepositoryLayer;
using CrudLevel1.DataConnection;
using Microsoft.EntityFrameworkCore;

namespace CrudLevel1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddScoped<IRepositoryCommute, RepositoryWork>();
            builder.Services.AddScoped<IPersonalService, PersonalServiceLayred>();
            builder.Services.AddAutoMapper(cfg => { }, typeof(MappingServiceDTO));

            // Add services to the container.
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

            builder.Services.AddDbContext<DataConnect>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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
