using NoteApiService.Model;
using NoteApiService.Repositories;
using NoteApiService.Repositories.Interfaces;
using NoteApiService.Services;
using NoteApiService.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Add Database
builder.Services.AddEntityFrameworkSqlite().AddDbContext<NoteContext>();

builder.Services.AddTransient<INoteService, NoteService>();
builder.Services.AddTransient<INoteRepository, NoteRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
