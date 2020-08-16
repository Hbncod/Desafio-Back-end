﻿using GerenciadorDeMedicos.Domains;
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
    }
}