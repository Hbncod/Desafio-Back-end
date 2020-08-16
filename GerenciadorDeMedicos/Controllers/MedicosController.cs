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
