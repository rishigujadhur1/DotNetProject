using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MovieAPI.Data;
using MovieAPI.Entities;
using MovieAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MoviesContext>(opt => { opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")); });
builder.Services.AddCors(cors => cors.AddPolicy("corsPolicy", build =>
{
    build.WithOrigins("http://127.0.0.1:3000/").AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();
}));


builder.Services.AddIdentityCore<User>()
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<MoviesContext>();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).
AddJwtBearer(opt =>
{
    opt.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true, // is token expired?
        ValidateIssuerSigningKey = true, // was signed by our API during its creation? 
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:TokenKey"]))
    };
});

builder.Services.AddAuthorization();
builder.Services.AddScoped<TokenService>();

var app = builder.Build();
app.UseCors("corsPolicy");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
