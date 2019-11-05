using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    interface IContaRepository : IBaseRepository<Conta>
    {
        void RealizarSaque(Conta conta, decimal valor);
        void RealizarDeposito(Conta conta, decimal valor);
        void RealizarTransferecia(Conta contaOrigem, Conta ContaDestino, decimal valor);
        Conta Obter(string agencia, string contaCorrente);
        bool ExisteSaldo(int id, decimal valor);
    }
   
}
