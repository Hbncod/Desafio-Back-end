using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeMedicos.Domains
{
    [Table("Especialidade")]
    public class Especialidade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id{ get; set; }
        [Column(TypeName = "VARCHAR (30)")]
        [Required(ErrorMessage = "O título da especialidade é necessário")]
        public string Titulo { get; set; }
        [InverseProperty(nameof(Medico.Especialidade1))]
        public List<Medico> Medicos { get; set; }
        [InverseProperty(nameof(Medico.Especialidade2))]
        public List<Medico> Medicoss { get; set; }
    }
}
