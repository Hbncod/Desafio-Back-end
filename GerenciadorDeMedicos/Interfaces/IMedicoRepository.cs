using GerenciadorDeMedicos.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeMedicos.Interfaces
{
    interface IMedicoRepository
    {
        /// <summary>
        /// Lista todos os médicos
        /// </summary>
        /// <returns>uma lista de médicos</returns>
        List<Medico> ListarMedicos();
        /// <summary>
        /// Cadastra um médico
        /// </summary>
        /// <param name="medico">dados do médico a ser cadastrado</param>
        /// <returns>retorna o id do médico</returns>
        int Cadastrar(Medico medico);
        /// <summary>
        /// Lista todos os médicos de uma determinada especialidade
        /// </summary>
        /// <param name="Id">Id da especialidade a ser buscada</param>
        /// <returns>retorna uma lista de médicos</returns>
        List<Medico> ListarMedicosPorEspecialidade(int Id);
        /// <summary>
        /// Deleta um médico
        /// </summary>
        /// <param name="id">id do médico a ser removido</param>
        void Deletar(int id);
        /// <summary>
        /// Busca um médico por seu id
        /// </summary>
        /// <param name="id">Id do médico a ser buscado</param>
        /// <returns></returns>
        Medico BuscarPorId(int id);
    }
}
