using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using casekeener.Models;
using System.Collections.Generic; 
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System;

namespace casekeener.Controllers
{
    public class ContaController : Controller
    {
        private readonly EstoqueWebContext dbContext;

        public ContaController(EstoqueWebContext context)
        {
            dbContext = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
public async Task<IActionResult> Login(UsuarioModel usuario)
{
    
    if (ModelState.ContainsKey("ConfirmPassword"))
    {
        ModelState.Remove("ConfirmPassword");
    }

    if (ModelState.IsValid)
    {
        var user = await dbContext.Usuarios
            .FirstOrDefaultAsync(u => u.Username == usuario.Username && u.Password == usuario.Password);

        if (user != null)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Username)
                
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
                IsPersistent = true,
                ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(30)
            };

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);

            
            return RedirectToAction("Index", "Produto");
        }

        ModelState.AddModelError(string.Empty, "Usuário ou senha inválidos.");
    }


            return View(usuario);
}

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Cadastro(UsuarioModel usuario)
        {
            if (ModelState.IsValid)
            {
                var userExists = await dbContext.Usuarios
                    .AnyAsync(u => u.Username == usuario.Username);

                if (userExists)
                {
                    ModelState.AddModelError(string.Empty, "O nome de usuário já está em uso.");
                    return View(usuario);
                }

                dbContext.Add(usuario);
                await dbContext.SaveChangesAsync();

                
                return RedirectToAction(nameof(Login));
            }

            return View(usuario);
        }
    }
}
