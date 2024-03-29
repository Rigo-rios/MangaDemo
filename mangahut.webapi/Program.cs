using MangaHut.Data;
using MangaHut.Services.MangaServices;
using MangaHut.Services.MangaServices.Contracts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(
                options => options
            .UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
            );

builder.Services.AddScoped<IStoreService,StoreService>();
builder.Services.AddScoped<ILocationService,LocationServices>();
builder.Services.AddScoped<IMangaService,MangaService>();
builder.Services.AddScoped<IStore_Manga_Service, Store_Manga_Service>();
// builder.Services.AddTransient<IStoreService,StoreService>(); // Lives only until the Application is not needed 
// builder.Services.AddSingleton<IStoreService,StoreService>(); // Lives for the entirety of the Application


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
