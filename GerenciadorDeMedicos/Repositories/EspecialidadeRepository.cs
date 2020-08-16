using GerenciadorDeMedicos.Context;
using GerenciadorDeMedicos.Domains;
using GerenciadorDeMedicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeMedicos.Repositories
{
    public class EspecialidadeRepository : IEspecialidadeRepository
    {
        private MedicosContext _context = new MedicosContext();

        public Especialidade BuscarPorId(int id)
        {
            return _context.Especialidade.FirstOrDefault(E => E.Id == id);
        }

        public int BuscarPorTitulo(string titulo)
        {
            Especialidade especialidade = _context.Especialidade.FirstOrDefault(E => E.Titulo == titulo);
            return especialidade.Id;
        }

        public void Criar(Especialidade especialidade)
        {
            _context.Especialidade.Add(especialidade);
            _context.SaveChanges();
        }

        public void Deletar(int IdEspecialidade)
        {
            Especialidade especialidadeExcluida = BuscarPorId(IdEspecialidade);
            _context.Especialidade.Remove(especialidadeExcluida);
            _context.SaveChanges();
        }
    }
}
