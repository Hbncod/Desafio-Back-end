using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeMedicos.Domains
{
    [Table("Medico")]
    public class Medico
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome do médico é obrigatório")]
        [Column(TypeName = "VARCHAR (255)")]
        [StringLength(255, ErrorMessage = "Nome não pode ser maior que 255 caracteres")]
        public string Nome { get; set; }
        [StringLength(14, ErrorMessage = "Cpf inválido")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "A Crm do médico é obrigatória")]
        [StringLength(14, ErrorMessage = "Cpf inválido")]
        public string Crm { get; set; }
        [Required(ErrorMessage = "o médico deve conter no minimo uma especialidade")]
        public List<string> Especialidades { get; set; }
    }
}
