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

        public void Notificar(string mensagem)
        {
            _notificador.Handle(new Notificacao(mensagem));
        }
    }
}
