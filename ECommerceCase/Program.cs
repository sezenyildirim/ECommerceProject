using ECommerce.DataAccess.Context;
using ECommerce.Entity.Entities;
using ECommerce.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddServiceRegister();
builder.Services.AddDbContext<eCommerceDBContext>(b => b.UseSqlServer
(builder.Configuration.GetConnectionString("SqlServer")));

builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<eCommerceDBContext>();
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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
