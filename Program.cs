using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MiradorWebAPI.Context;
using System;
using System.Text;

var builder = WebApplication.CreateBuilder(args);


//builder.Services.AddControllers(
//    //config => config.Filters.Add(new AuthorizeFilter())
//    );

var authPol = new AuthorizationPolicyBuilder()
    .AddAuthenticationSchemes(new string[]
    {
        JwtBearerDefaults.AuthenticationScheme
    })
    .RequireAuthenticatedUser()
    .Build();

builder.Services.AddControllers(
        conf =>
        {
            conf.Filters.Add(new AuthorizeFilter(authPol));
        }
    );

builder.Services.AddDbContext<FUPContext>();
//STEP 1 Microsoft.AspNetCore.Identity.EntityFrameworkCore

//STEP 2
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<FUPContext>()
    .AddDefaultTokenProviders();

var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("This-is-my-jwt-secret-key-for-jwt"));
var tokenValidationParameter = new TokenValidationParameters()
{
    IssuerSigningKey = signingKey,
    ValidateIssuer = false,
    ValidateAudience = false,
    ClockSkew = TimeSpan.Zero
};

builder.Services.AddAuthentication(x => x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(jwt =>
    {
        jwt.TokenValidationParameters = tokenValidationParameter;
    });

//STEP 3

//builder.Services.ConfigureApplicationCookie(opt =>
//{
//    opt.ExpireTimeSpan = new TimeSpan(0, 0, 45);
//    opt.Events = new Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationEvents()
//    {
//        //AUTHENTICATIOB
//        OnRedirectToLogin = redirectContext =>
//        {
//            redirectContext.HttpContext.Response.StatusCode = 403;
//            return Task.CompletedTask;
//        },
//        //AUTHORIZATION
//        OnRedirectToAccessDenied = redirectContext =>
//        {
//            redirectContext.HttpContext.Response.StatusCode = 401;
//            return Task.CompletedTask;
//        }
//    };
//});




builder.Services.AddControllers();
builder.Services.AddOpenApiDocument(x => { x.Title = "MIRADOR WEB API"; });

//builder.Services.AddDbContext<FUPContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerConnection")));
var app = builder.Build();

app.MapGet("/", () => "Bienvenue");

app.UseStaticFiles();
app.UseRouting();
// STEP 4
app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
app.UseOpenApi();
app.UseSwaggerUi();
app.UseReDoc();

app.UseReDoc(options =>
{
    options.Path = "/redoc";
});




app.Run();
