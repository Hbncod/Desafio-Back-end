using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using GerenciadorDeMedicos.Domains;
using GerenciadorDeMedicos.Interfaces;
using GerenciadorDeMedicos.Repositories;
using GerenciadorDeMedicos.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace GerenciadorDeMedicos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository { get; set; }
        public LoginController()
        {
            _usuarioRepository = new UsuarioRepository();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel Login)
        {
            try
            {
                Usuario usuariobuscado = _usuarioRepository.BuscarPorEmaileSenha(Login);

                if (usuariobuscado == null)
                {
                    return NotFound("E-mail ou senha inválidos");
                }
                var claims = new[]
                {
                new Claim(JwtRegisteredClaimNames.Email,usuariobuscado.Email),
                new Claim(JwtRegisteredClaimNames.Jti, usuariobuscado.Id.ToString()),
            };
                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("GerenciadorMedicos-chave-autenticacao"));

                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                // Gera o token
                var token = new JwtSecurityToken(
                    issuer: "GerenciadorMedicos.WebApi",            
                    audience: "GerenciadorMedicos.WebApi",       
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(30),
                    signingCredentials: creds   
                );

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
