using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using bus_project.Data;

var builder = WebApplication.CreateBuilder(args);


var connectionString = "Host=localhost;Port=5050;Database=DBATransportProject;Username=postgres;Password=3961598;";
builder.Services.AddDbContext<DBContext>(options =>
    options.UseNpgsql(connectionString));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=MainPage}/{id?}");

app.MapControllerRoute(
    name: "deleteCompany",
    pattern: "TransportCompany/DeleteCompany/{id}",
    defaults: new { controller = "TransportCompany", action = "DeleteCompany" }
);

app.MapControllerRoute(
    name: "deleteCompanyConfirmed",
    pattern: "TransportCompany/DeleteCompanyConfirmed/{id}",
    defaults: new { controller = "TransportCompany", action = "DeleteCompanyConfirmed" }
);


app.Run();