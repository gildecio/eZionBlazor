using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
 

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<eZionBlazor.Contabil.Services.IEmpresaService, eZionBlazor.Contabil.Services.EmpresaService>();
builder.Services.AddScoped<eZionBlazor.Services.AuthService>();
// Removido DbContext ausente para manter build estável

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

// Removida migração automática de banco enquanto não há DbContext

app.Run();
