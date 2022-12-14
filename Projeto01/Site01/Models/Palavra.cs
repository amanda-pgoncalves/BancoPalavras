using Microsoft.SqlServer.Dac.Model;
using Site01.Library.Validation;
using System.ComponentModel.DataAnnotations;

namespace Site01.Models
{
    public class Palavra
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo 'Nome' é obrigatório!")]
        [MaxLength(70, ErrorMessage = "O campo 'Nom' deve conter o máximo de 70 caracteres!")]
        [UnicoNomePalavra]
        public string Nome { get; set; }

        // 1- Fácil, 2-Médio, 3-Difícil
        public byte? Nivel { get; set; }
    }
}
