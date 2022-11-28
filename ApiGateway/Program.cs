using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using System.Text;


var builder = WebApplication.CreateBuilder(args);

//var secret = "ThisIsMySecret";
//var key = Encoding.ASCII.GetBytes(secret);
//builder.Services.AddAuthentication(option =>
//{
//    option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//    option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//}).AddJwtBearer("Bearer", option =>
//{
//    option.RequireHttpsMetadata = false;
//    option.SaveToken = true;
//    option.TokenValidationParameters = new TokenValidationParameters
//    {
//        IssuerSigningKey = new SymmetricSecurityKey(key),
//        ValidateIssuerSigningKey = true,
//        ValidateIssuer = false,
//        //ValidAudience = false   
//    };
//});

builder.Services.AddOcelot();
builder.Configuration.AddJsonFile("ocelot.json");



var app = builder.Build();
//app.UseAuthentication();

app.UseOcelot();
app.Run();
