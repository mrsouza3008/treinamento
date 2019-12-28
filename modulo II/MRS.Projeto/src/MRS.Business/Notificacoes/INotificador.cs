using System;
using System.Collections.Generic;
using System.Text;

namespace MRS.Business.Notificacoes
{
    public interface INotificador
    {
        bool TemNotificacao();

        List<Notificacao> ObterNotificacao();
        void Handle(Notificacao notificacao);

    }
}
