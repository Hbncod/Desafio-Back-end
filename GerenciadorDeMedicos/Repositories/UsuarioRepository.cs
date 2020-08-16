using GerenciadorDeMedicos.Context;
using GerenciadorDeMedicos.Domains;
using GerenciadorDeMedicos.Interfaces;
using GerenciadorDeMedicos.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeMedicos.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private MedicosContext _context = new MedicosContext();
        public Usuario BuscarPorEmaileSenha(LoginViewModel loginViewModel)
        {
            return _context.Usuario.FirstOrDefault(U => U.Email == loginViewModel.Email && U.Senha == loginViewModel.Senha);
        }

        public Usuario BuscarPorId(int id)
        {
            return _context.Usuario.FirstOrDefault(U => U.Id == id);
        }

        public void Cadastrar(Usuario usuario)
        {
            _context.Usuario.Add(usuario);
            _context.SaveChanges();
        }

        public void Deletar(int Id)
        {
            Usuario UsuarioDeletado = BuscarPorId(Id);
            _context.Usuario.Remove(UsuarioDeletado);
            _context.SaveChanges();
        }
    }
}
