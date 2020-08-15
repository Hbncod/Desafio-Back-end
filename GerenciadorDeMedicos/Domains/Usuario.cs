using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeMedicos.Domains
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName = "VARCHAR(150)")]
        [StringLength(150, ErrorMessage = "O máximo de caracteres permitido é 150")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "O E-mail do usuario é obrigatório")]
        public string Email { get; set; }
        [Column(TypeName = "VARCHAR (30)")]
        [DataType(DataType.Password)]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "A senha deve conter entre 5 e 30 caracteres.")]
        [Required(ErrorMessage = "A Senha do usuario é obrigatória")]
        public string Senha { get; set; }
    }
}
