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
            /// Adiciona uma implementação padrão de IDistributedCache
            /// 
            /// Com base em um dicionário ou tabela hash no servidor, o estado
            /// da e sessão persiste os dados através das requisições de uma navegador.
            /// O estado da sessão é mantido, dando ao cliente um cookie que contém
            /// o ID da sessão, que é enviado ao servidor com cada solicitação.
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