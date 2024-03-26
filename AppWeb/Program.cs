// using Infraestructura.Datos.Listas;
using Infraestructura.Datos.EF;
using LogicaAplicacion.Paises;
using LogicaAplicacion.Temas;
using LogicaNegocio.Entidades;
using LogicaNegocio.InterfazRepositorio;
using LogicaNegocio.InterfazServicios;

namespace AppWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // Dependency Injection (DI) configuration for the repository classes in the LogicAccessData project

            // Repositories for the entities in the LogicAccessData project
            builder.Services.AddScoped<IRepositorioTema, RepositorioTema>();

            // Services for the entities in the LogicAccessData project (CRUD operations) / casos de uso
            builder.Services.AddScoped<IAlta<Tema>, AltaTema>();
            builder.Services.AddScoped<IEditar<Tema>, EditarTema>();
            builder.Services.AddScoped<IEliminar<Tema>, EliminarTema>();
            builder.Services.AddScoped<IObtener<Tema>, ObtenerTema>();
            builder.Services.AddScoped<IObtenerTodos<Tema>, ObtenerTemas>();

            builder.Services.AddScoped<IRepositorioPais, RepositorioPais>();
            builder.Services.AddScoped<IAlta<Pais>, AltaPais>();
            builder.Services.AddScoped<IEditar<Pais>, EditarPais>();
            builder.Services.AddScoped<IEliminar<Pais>, EliminarPais>();
            builder.Services.AddScoped<IObtener<Pais>, ObtenerPais>();
            builder.Services.AddScoped<IObtenerTodos<Pais>, ObtenerPaises>();

            // Add the context to the container to be able to interact with the database using EF
            builder.Services.AddDbContext<BibliotecaContext>();

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
        }
    }
}
