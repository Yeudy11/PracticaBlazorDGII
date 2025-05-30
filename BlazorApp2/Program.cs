using BlazorApp2.Components;
using Microsoft.EntityFrameworkCore;
using BlazorApp2;
using BlazorApp2.Repository;

var builder = WebApplication.CreateBuilder(args);

// ✅ Obtener la cadena de conexión desde appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

#if DEBUG
builder.Services.AddDbContextFactory<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString)
           .EnableSensitiveDataLogging());
#else
builder.Services.AddDbContextFactory<DBADGIIContext>(options =>
    options.UseSqlServer(connectionString));
#endif

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddQuickGridEntityFrameworkAdapter();
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddTransient<ITipoRepository, TipoRepository>();
builder.Services.AddTransient<IEstatusRepository, EstatusRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();



app.Run();

