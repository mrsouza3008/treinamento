using FluentValidation;
using MRS.Business.Model;
using System;
using System.Collections.Generic;
using System.Text;
using static MRS.Business.Validations.Personalizados.Documentos;

namespace MRS.Business.Validations
{
    public class FornecedorValidation : AbstractValidator<Fornecedor>
    {
        public FornecedorValidation()
        {
            RuleFor(f => f.Nome)
                .Length(2, 100).WithMessage("Nome precisa ter entre 2 e 100 caracteres")
                .NotEmpty().WithMessage("Precisa ser informado um nome");

            When(f => f.TipoFornecedor == TipoFornecedor.Fisica, () =>
            {
                RuleFor(f => f.Documento.Length).Equal(CpfValidacao.TamanhoCpf)
                    .WithMessage("O documento precisa ter 11 caracteres");
                RuleFor(f => CpfValidacao.Validar(f.Documento)).Equal(true)
                    .WithMessage("CPF inválido");
            });

            When(f => f.TipoFornecedor == TipoFornecedor.Juridica, () =>
            {
                RuleFor(f => f.Documento.Length).Equal(CnpjValidacao.TamanhoCnpj)
                    .WithMessage("O documento precisa ter 14 caracteres");
                RuleFor(f => CnpjValidacao.Validar(f.Documento)).Equal(true)
                    .WithMessage("CNPJ inválido");
            });


        }
    }
}
