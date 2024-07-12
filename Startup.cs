using System;
using casekeener.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace casekeener
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // Configuração do DbContext
            services.AddDbContext<EstoqueWebContext>(options =>
                options.UseSqlite(Configuration.GetConnectionString("EstoqueWebContext")));

            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            // Configuração de autenticação via cookies
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.Cookie.HttpOnly = true;
                    options.ExpireTimeSpan = TimeSpan.FromMinutes(30); // Tempo de expiração do cookie
                    options.LoginPath = "/Conta/Login"; // Caminho de redirecionamento para o login
                    options.AccessDeniedPath = "/Conta/AcessoNegado"; // Caminho de redirecionamento para acesso negado
                    options.SlidingExpiration = true; // Renova o tempo de expiração do cookie a cada requisição
                });

            services.AddAuthorization();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication(); // Middleware de autenticação
            app.UseAuthorization(); // Middleware de autorização

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Conta}/{action=Login}/{id?}");
            });
        }
    }
}
