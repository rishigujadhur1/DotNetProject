using Microsoft.EntityFrameworkCore;
using NotesAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<NotesContext>(opt =>
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// enable cors
builder.Services.AddCors(cors => cors.AddPolicy("corsPolicy", build =>
{
    build.WithOrigins("http://127.0.0.1:5500/").AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();
}));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("corsPolicy");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();



app.Run();
