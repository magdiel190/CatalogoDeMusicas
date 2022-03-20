using CatalogoDeMusicas.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<TabelaBd>
    (options => options.UseMySql("server=localhost;initial catalog=CatalogoDeMusicas;user=root;password=H57r3m6q3DRWtCc1WBnN7Amjw", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.28 -mysql")));

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/cadastroes/Error");
    
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=cadastroes}/{action=Index}/{id?}");

app.Run();
