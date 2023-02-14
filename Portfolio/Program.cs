using Portfolio.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//=============================================================================
// SECCION INYECCION DE DEPENDENCIAS
//=============================================================================
// en services puedo realizar la inyeccion de dependencias. Cuando alguien pida la interfaz se le enviara el otro parametro
//=============================================================================

builder.Services.AddTransient<IRepository, ProjectsRepository>();
//==============================================================================================================================
//Trasient, scope y singleton son servicios que varian segun el ciclo de vida
//==============================================================================================================================
// De acuerdo a su duracion.                      | De acuerdo a su uso
//==============================================================================================================================
//Transient = Transitorio (cada vez que se carga) |  si no requiere compartir datos entre distintas instancias del servicio
//Scope = Delimitado por una peticcion http       |  Si necesitaramos compartir datos con otras instancias pero dentro de la misma peticion
//Singleton = Unico/Para siempre                  |  Si necesitaramos compartir datos con otras instancias
//==============================================================================================================================
//builder.Services.AddTransient<ServiceTransient>();
//builder.Services.AddSingleton<ServiceUnico>();
//builder.Services.AddScoped<ServiceScope>();
//==============================================================================================================================



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

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
