using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebshopAPI.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Local Connection string:
var connectionString = "Data Source=mssql;User ID=sa;Password=Wachtwoord1!;Database=webshopDB;TrustServerCertificate=True;MultiSubnetFailover=True;";
/*var connectionString = "Data Source=sql-webshopDB;User ID=sa;Password=Wachtwoord1!;Database=LocalwebshopDB";*/

//Remote connection string:
/*var connectionString = "Data Source=192.168.2.23,1433;User ID=sa;Password=Wachtwoord1!;Database=webshopDB;TrustServerCertificate=True;MultiSubnetFailover=True;";*/

/*var connectionString = "Data Source=host.docker.internal,1433;User ID=sa;Password=Wachtwoord1!;Database=webshopDB;TrustServerCertificate=True;MultiSubnetFailover=True;";*/
/*var connectionString = "Data Source=86.87.181.16,1433;User ID=sa;Password=Wachtwoord1!;Database=webshopDB;TrustServerCertificate=True;MultiSubnetFailover=True;";*/
builder.Services
    .AddDbContext<WebshopContext>(options => options.UseSqlServer(connectionString));

var app = builder.Build();

 //Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

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

/*app.UseHttpsRedirection();*/
/*app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
});*/

app.UseAuthorization();

app.MapControllers();

app.Run();
