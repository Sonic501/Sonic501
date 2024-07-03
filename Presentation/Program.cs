using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Lấy chuỗi kết nối
var sqlConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");
// Kết nối với Database
builder.Services.AddDbContext<EcommerceContext>(options =>
        options.UseSqlServer(sqlConnectionString));

builder.Services.AddControllers();
builder.Services.AddControllersWithViews()
    .AddNewtonsoftJson(options =>
    {
        options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
        options.SerializerSettings.Converters.Add(new StringEnumConverter());
        options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
    }
);
builder.Services.AddSwaggerGenNewtonsoftSupport();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwagger();
builder.Services.AddDependenceInjection();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseJwt();

app.UseAuthorization();

app.MapControllers();

app.Run();
