using Books;
using DbData.DbModels;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<LibraryContext>(options =>
{
    //поменять на Server=(localdb)\MSSQLLocalDB;Database=Library;Trusted_Connection=True;
    options.UseSqlServer("Server=WOOF\\WOOFSQLSERVER;Database=Library;User ID=sa;Password=kbghbrjy;TrustServerCertificate=True;");
});

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<StudentStorageService>();
builder.Services.AddScoped<BookStorageService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
