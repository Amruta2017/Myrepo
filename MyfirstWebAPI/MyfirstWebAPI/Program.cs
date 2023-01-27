using Microsoft.EntityFrameworkCore;
using MyfirstWebAPI.Data;
using MyfirstWebAPI.Model.Profiles;
using MyfirstWebAPI.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Automapper Injucted
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
//Inject DB context Class
builder.Services.AddDbContext<NZWalksDBContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("NZwalks"));
}); 
//Repository injucted 
builder.Services.AddScoped<IRegionRepository ,RegionRepository > ();
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
