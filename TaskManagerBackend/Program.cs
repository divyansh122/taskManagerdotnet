using Microsoft.EntityFrameworkCore;
using TaskManagerBackend.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend",
        policy => policy.WithOrigins("http://localhost:3000").AllowAnyMethod().AllowAnyHeader());
});

var app = builder.Build();
app.UseCors("AllowFrontend");
app.UseAuthorization();
app.MapControllers();
app.Run();
