using Site01.Database;
using Site01.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Site01.Library.Validation
{
    public class UnicoNomePalavraAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Palavra palavra = validationContext.ObjectInstance as Palavra;

            var _db = (DatabaseContext)validationContext.GetService(typeof(DatabaseContext));

            // Já existe no banco de dados 1 registro:
            // - Verificar se nome existe
            // - Verificar se o Id é o mesmo do registro do banco.

            var palavraBanco = _db.Palavras.Where(a => a.Nome == palavra.Nome && a.Id != palavra.Id).FirstOrDefault();

            if(palavraBanco == null)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("A palavra '"+ palavra.Nome +"' já está sendo utilizada!");
            }
        }


    }
}
