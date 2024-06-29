using pruebaTecnicaMoventi.Repositories.Implementations;
using pruebaTecnicaMoventi.Repositories.Interfaces;
using pruebaTecnicaMoventi.Services.Implementations;
using pruebaTecnicaMoventi.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Repositorios
builder.Services.AddSingleton<IDocumentTypeRepository, DocumentTypeRepository>();
builder.Services.AddScoped<IClientScoreRepository, ClientScoreRepository>();

// Servicios
builder.Services.AddScoped<IDocumentTypeService, DocumentTypeService>();
builder.Services.AddScoped<IClientScoreService, ClientScoreService>();

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

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSwagger();
app.UseSwaggerUI();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
