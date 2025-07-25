using Microsoft.EntityFrameworkCore;
using ResumePS.Core.Services.Implementations;
using ResumePS.Core.Services.Interfaces;
using ResumePS.Data.Context;
using ResumePS.Data.Repositories;
using ResumePS.Domain.Interfaces;
using ResumePS.Ioc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

#region Add Db Context
builder.Services.AddDbContext<ResumePSContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Myconnection"));
});
#endregion
builder.Services.RegisterServices();
//builder.Services.AddScoped<IUserService, UserService>();
//builder.Services.AddScoped<IUserRepository, UserRepository>();

//builder.Services.AddScoped<IWebMainInfoService, WebMainInfoService>();
//builder.Services.AddScoped<IWebMainInfoRepository, WebMainInfoRepository>();


//builder.Services.AddScoped<IWebContactUsService, WebContactUsService>();
//builder.Services.AddScoped<IWebContactUsRepository, WebContactUsRepository>();

WebApplication app = builder.Build();

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
