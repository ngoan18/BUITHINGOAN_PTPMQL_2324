using System;
/*var builder = WebApplication.CreateBuilder(args);

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
*/


using Testapp.Models;
public class  Program
{
    private static void Main(string [] args)
    {
    Nhansu ns =new Nhansu();
    ns.Tenns = "Ha";
    ns.Chucvu = "quanly";
    ns.Tuoi = 22;
    ns.Luong ="230";
    ns.Display();
    
    
}
}

