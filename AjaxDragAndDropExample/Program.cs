using AjaxDragAndDropExample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AjaxDbContext>(opt => opt.UseSqlServer("Data Source =localhost\\SQLEXPRESS; Initial Catalog = AjaxDb; Integrated Security = True", options => options.MigrationsAssembly("AjaxDragAndDropExample").MigrationsHistoryTable(HistoryRepository.DefaultTableName, "dbo")));
builder.Services.AddSession();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Customer}/{action=Index}/{id?}");

app.Run();
