using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebshopAPI.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = "Data Source=localhost,1433;User ID=sa;Password=Wachtwoord1!;Database=webshop_db";

builder.Services
    .AddDbContext<WebshopContext>(options => options.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
/*if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}*/

using (var scope = app.Services.CreateScope())
{
    //running migrations at startup
    var db = scope.ServiceProvider.GetRequiredService<WebshopContext>();
    db.Database.Migrate();
    //adding seeddata

    var services = scope.ServiceProvider;
    SeedData.Initialize(services);

}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    // app.UseHsts();
}

app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
