using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using MiradorWebAPI.Context;
using System;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<FUPContext>();

builder.Services.AddControllers(
    config => config.Filters.Add(new AuthorizeFilter())
    );
//STEP 1 Microsoft.AspNetCore.Identity.EntityFrameworkCore

//STEP 2
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<FUPContext>()
    .AddDefaultTokenProviders();
//STEP 3

builder.Services.ConfigureApplicationCookie(opt =>
{
    opt.Events = new Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationEvents()
    {
        //AUTHENTICATIOB
        OnRedirectToLogin = redirectContext =>
        {
            redirectContext.HttpContext.Response.StatusCode = 403;
            return Task.CompletedTask;
        },
        //AUTHORIZATION
        OnRedirectToAccessDenied = redirectContext =>
        {
            redirectContext.HttpContext.Response.StatusCode = 401;
            return Task.CompletedTask;
        }
    };
});











builder.Services.AddControllers();
builder.Services.AddSwaggerDocument(x => { x.Title = "My Org API"; });

//builder.Services.AddDbContext<FUPContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerConnection")));
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.UseStaticFiles();
app.UseRouting();

app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
app.UseOpenApi();
app.UseSwaggerUi();
app.UseReDoc();

app.UseReDoc(options =>
{
    options.Path = "/redoc";
});

// STEP 4
app.UseAuthentication();
app.UseAuthorization();


app.Run();
