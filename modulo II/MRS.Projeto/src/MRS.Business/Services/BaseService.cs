﻿using FluentValidation;
using FluentValidation.Results;
using MRS.Business.Model;
using MRS.Business.Notificacoes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MRS.Business.Services
{
    public abstract class BaseService
    {
        private readonly INotificador _notificador;

        public BaseService(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected void Notificar(string mensagem)
        {
            _notificador.Handle(new Notificacao(mensagem));
        }

        protected bool EfetuarValidacao<V, E>(V validacao, E entidade)
            where V : AbstractValidator<E>
            where E : Entity
        {
            //Validar se o documento é valido
            ValidationResult result = validacao.Validate(entidade);

            if (!result.IsValid)
            {
                foreach (var err in result.Errors)
                {
                    Notificar(err.ErrorMessage);
                }
                return false;
            }

            return true;
        }
    }
}
