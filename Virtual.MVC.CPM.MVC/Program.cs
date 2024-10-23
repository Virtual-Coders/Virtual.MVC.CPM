using Virtual.MVC.CPM.Data;
using Microsoft.EntityFrameworkCore;
using Virtual.MVC.CPM.Domains;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplication();
//builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

// Add services to the container
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase(builder.Configuration.GetConnectionString("DefaultConnection")));


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
