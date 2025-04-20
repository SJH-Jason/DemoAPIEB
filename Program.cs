using DemoAPIEB.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DemoDataListContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddCors(options =>
{
    //options.AddPolicy("AllowVueApp",
    //    policy =>
    //    {
    //        policy.WithOrigins(
    //            "http://localhost:5173",    // Vue 開發用
    //            "https://localhost:7078"    // Vue 打包後部署在 Web 專案
    //        )
    //        .AllowAnyHeader()
    //        .AllowAnyMethod();
    //    });

    //測試用全開不限制
    options.AddPolicy("AllowLocalhost",
        policy =>
        {
            policy
                .SetIsOriginAllowed(origin =>
                    new Uri(origin).Host == "localhost" || new Uri(origin).Host == "127.0.0.1")
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseCors("AllowVueApp");
//測試用全開不限制
app.UseCors("AllowLocalhost");

app.UseAuthorization();

app.MapControllers();

app.Run();
