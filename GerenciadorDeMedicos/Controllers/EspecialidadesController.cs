using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    public class EspecialidadesController : ControllerBase
    {
        private IEspecialidadeRepository _especialidadeRepository { get; set; }
        public EspecialidadesController()
        {
            _especialidadeRepository = new EspecialidadeRepository();
        }
        [HttpPost]
        public IActionResult Criar(Especialidade especialidade)
        {
            try
            {
                especialidade.Id = 0;
                _especialidadeRepository.Criar(especialidade);
                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Criar(int id)
        {
            try
            {
                _especialidadeRepository.Deletar(id);
                return StatusCode(200);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
