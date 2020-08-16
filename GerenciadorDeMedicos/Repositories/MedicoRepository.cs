using GerenciadorDeMedicos.Context;
using GerenciadorDeMedicos.Domains;
using GerenciadorDeMedicos.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeMedicos.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        private MedicosContext _context = new MedicosContext();

        public Medico BuscarPorId(int id)
        {
            return _context.Medico.FirstOrDefault(M => M.Id == id);
        }

        public int Cadastrar(Medico medico)
        {
            _context.Medico.Add(medico);
            _context.SaveChanges();
             medico = _context.Medico.FirstOrDefault(M => M.Cpf == medico.Cpf);
            return medico.Id;
        }

        public void Deletar(int id)
        {
            Medico medicoDeletado = BuscarPorId(id);
            _context.Medico.Remove(medicoDeletado);
            _context.SaveChanges();
        }

        public List<Medico> ListarMedicos()
        {
            return _context.Medico.ToList();
        }

        public List<Medico> ListarMedicosPorEspecialidade(int Id)
        {
            return _context.Medico.Include(M => M.Especialidade1).Include(M => M.Especialidade2).Where(M => M.Fk_Especialidade1 == Id || M.Fk_Especialidade2 == Id).ToList();
        }
    }
}
