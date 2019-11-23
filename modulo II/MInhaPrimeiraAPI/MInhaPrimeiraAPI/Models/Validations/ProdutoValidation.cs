using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MInhaPrimeiraAPI.Models.Validations
{
    public class ProdutoValidation  : AbstractValidator<Produto>
    {
        public ProdutoValidation()
        {
            RuleFor(x => x.Descricao)
                .NotEmpty()
                .MaximumLength(60)
                .WithMessage("Descrição precisa ser informada")
                ;

            RuleFor(x => x.Valor)
                .NotEmpty()
                .WithMessage("Necessário informar um valor")
                ;

        }
    }
}
