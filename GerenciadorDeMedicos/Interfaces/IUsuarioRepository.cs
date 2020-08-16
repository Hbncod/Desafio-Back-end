using GerenciadorDeMedicos.Domains;
using GerenciadorDeMedicos.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeMedicos.Interfaces
{
    interface IUsuarioRepository
    {
        /// <summary>
        /// Busca um usuário por email e senha
        /// </summary>
        /// <param name="loginViewModel">dados do usuário buscado</param>
        /// <returns>o usuário referente ao email e senha informados</returns>
        Usuario BuscarPorEmaileSenha(LoginViewModel loginViewModel);
        /// <summary>
        /// Cadastra um novo usuário
        /// </summary>
        /// <param name="usuario">Dados do usuário a ser cadastrado</param>
        void Cadastrar(Usuario usuario);
        /// <summary>
        /// Deleta um usuário
        /// </summary>
        /// <param name="Id">Id do usuário a ser deletado</param>
        void Deletar(int Id);
    }
}
