using LanchesMac.Context;
using LanchesMac.Repositories;
using LanchesMac.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Configuration.AddJsonFile("appsettings.json");
            var configuration = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddDbContext<AppDbContext>(options =>
                    options.UseSqlServer(configuration));

            /// <summary>
            /// 
            /// Adiciona uma implementa��o padr�o de IDistributedCache
            /// 
            /// Com base em um dicion�rio ou tabela hash no servidor, o estado
            /// da e sess�o persiste os dados atrav�s das requisi��es de uma navegador.
            /// O estado da sess�o � mantido, dando ao cliente um cookie que cont�m
            /// o ID da sess�o, que � enviado ao servidor com cada solicita��o.
            /// 
            /// </summary>
            
            builder.Services.AddMemoryCache();
            builder.Services.AddSession();

            builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            
            builder.Services.AddTransient<ILancheRepository, LancheRepository>();
            builder.Services.AddTransient<IBebidaRepository, BebidaRepository>();
            builder.Services.AddTransient<ISobremesaRepository, SobremesaRepository>();
            builder.Services.AddTransient<ICategoriaRepository, CategoriaRepository>();

            builder.Services.AddControllersWithViews();
            
            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}