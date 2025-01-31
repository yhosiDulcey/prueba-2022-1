using Torneo.App.Persistencia;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<IRepositorioMunicipio, RepositorioMunicipio>();
builder.Services.AddSingleton<IRepositorioDT, RepositorioDT>();
builder.Services.AddSingleton<IRepositorioEquipo, RepositorioEquipo>();
builder.Services.AddSingleton<IRepositorioArbitro, RepositorioArbitro>();
builder.Services.AddSingleton<IRepositorioJugador, RepositorioJugador>();
builder.Services.AddSingleton<IRepositorioPartido, RepositorioPartido>();
builder.Services.AddSingleton<IRepositorioEstadio, RepositorioEstadio>();
builder.Services.AddSingleton<IRepositorioPartido, RepositorioPartido>();
builder.Services.AddSingleton<IRepositorioPosicion, RepositorioPosicion>();

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

app.UseAuthorization();

app.MapRazorPages();

app.Run();
