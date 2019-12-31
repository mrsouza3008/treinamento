using FluentValidation;
using MRS.Business.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MRS.Business.Validations
{
    public class ProdutoValidation : AbstractValidator<Produto>
    {
        public ProdutoValidation()
        {
            RuleFor(p => p.Nome)
               .Length(2, 200).WithMessage("Nome precisa ter entre 2 e 200 caracteres")
               .NotEmpty().WithMessage("Precisa ser informado um nome");

            RuleFor(p => p.Descricao)
               .Length(2, 1000).WithMessage("Descricao precisa ter entre 2 e 1000 caracteres")
               .NotEmpty().WithMessage("Precisa ser informado uma Descricao");
        }
    }
}
