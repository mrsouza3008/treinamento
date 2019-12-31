using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using MRS.Business.Notificacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MRS.Api.Controllers
{
    [ApiController]
    public abstract class MainController : ControllerBase
    {
        private INotificador _notificador;

        protected MainController(INotificador notificador)
        {
            _notificador = notificador;

        }

        protected ActionResult Result(object obj = null)
        {
            // validacoes OK
            if (!_notificador.TemNotificacao())
            {
                return Ok(new
                {
                    sucesso = true,
                    data = obj
                });

            }

             
            // Validações não OK

           return BadRequest(new
           {
               sucesso = false,
               erros = _notificador.ObterNotificacao().Select(n => n.Mensagem)
           });
        }

        protected ActionResult Result(ModelStateDictionary modelState)
        {
            ObterNotificacoesModelInvalida(modelState);

            return Result();
        }

        protected void ObterNotificacoesModelInvalida(ModelStateDictionary modelState)
        {

            var errors = modelState.Values.SelectMany(e => e.Errors);

            foreach (var erro in errors)
            {
                string mensagemErro = erro.Exception == null ? erro.ErrorMessage : erro.Exception.Message;
                _notificador.Handle(new Notificacao(mensagemErro));
            }

            
        }
    }
}
