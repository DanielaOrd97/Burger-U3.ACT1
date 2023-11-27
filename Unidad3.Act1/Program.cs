using Microsoft.EntityFrameworkCore;
using Unidad3.Act1.Models.Entities;

var builder = WebApplication.CreateBuilder(args);



//builder.Services.AddDbContext<NeatContext>(x =>
//    x.UseMySql("server=localhost;user=root;password=root;database=Neat", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.28-mysql")));

builder.Services.AddDbContext<NeatContext>(x => 
                            x.UseMySql("server=localhost;user=root;password=root;database=Neat", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.28-mysql")));

builder.Services.AddMvc();
var app = builder.Build();
app.UseStaticFiles();
app.UseFileServer();

app.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
          );     //Ruteo de areas

app.MapDefaultControllerRoute();

app.Run();
