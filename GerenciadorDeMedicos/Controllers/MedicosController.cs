using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GerenciadorDeMedicos.Domains;
using GerenciadorDeMedicos.Interfaces;
using GerenciadorDeMedicos.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeMedicos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicosController : ControllerBase
    {
        private IMedicoRepository _medicoRepository { get; set; }
        public MedicosController()
        {
            _medicoRepository = new MedicoRepository();
        }
        /// <summary>
        /// Lista todos os médicos
        /// </summary>
        /// <returns>status code 200 e uma lista de médicos</returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_medicoRepository.ListarMedicos());
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        /// <summary>
        /// Busca uma lista de médicos que possuem uma especialidade especifica 
        /// </summary>
        /// <param name="especialidade">nome da especialidade</param>
        /// <returns>status code 200 e uma lista de médicos que possuem uma especialidade especifica </returns>
        [HttpGet("{especialidade}")]
        public IActionResult GetByEspecialidades(string especialidade)
        {
            try
            {
                EspecialidadeRepository esp = new EspecialidadeRepository();
                return Ok(_medicoRepository.ListarMedicosPorEspecialidade(esp.BuscarPorTitulo(especialidade)));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        /// <summary>
        /// Cadastra um novo médico
        /// </summary>
        /// <param name="medico">dados do médico</param>
        /// <returns>status code 200 e Id do médico cadastrado</returns>
        [HttpPost]
        public IActionResult Cadastrar(Medico medico)
        {
            try
            {
                return Ok(_medicoRepository.Cadastrar(medico));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        /// <summary>
        /// Deleta um médico
        /// </summary>
        /// <param name="id">Id do médico a ser deletado</param>
        /// <returns>Status code 200</returns>
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                _medicoRepository.Deletar(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

    }
}
