using GerenciadorDeMedicos.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeMedicos.Interfaces
{
    interface IEspecialidadeRepository
    {
        /// <summary>
        /// Adiciona uma especialidade
        /// </summary>
        /// <param name="especialidade">dados da especialidade</param>
        void Criar(Especialidade especialidade);
        /// <summary>
        /// Deleta uma especialidade
        /// </summary>
        /// <param name="IdEspecialidade">Id da especialidade a ser excluida</param>
        void Deletar(int IdEspecialidade);
        /// <summary>
        /// Busca uma especialidade por id
        /// </summary>
        /// <param name="id">id da especialidade a ser buscada</param>
        /// <returns></returns>
        Especialidade BuscarPorId(int id);
        /// <summary>
        /// busca uma especialidade por seu titulo
        /// </summary>
        /// <param name="titulo"></param>
        /// <returns>retorna o id da especialidade buscada</returns>
        int BuscarPorTitulo(string titulo);
    }
}
