using Microsoft.EntityFrameworkCore;
using WorkerData.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Dependency Injection
//Connection to the DB
builder.Services.AddDbContext<WorkerDbContext>(options =>{
options.UseMySql(builder.Configuration.GetConnectionString("WorkerDataConnection"),
  Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.6.12-mysql"));
});


var app = builder.Build();




// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    //pattern: "{controller=Home}/{action=Index}/{id?}");
    pattern: "{controller=Worker}/{action=Index}/{id?}");
app.Run();
