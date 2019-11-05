using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2.Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaRepository repository = new ContaRepository();

           

            #region Inserir Conta
            Conta conta = new Conta();
            conta.Limite = 100;
           // conta.Nascimento = new DateTime(1978, 08, 30);
           //conta.NomeTitular = "Souza";
            conta.Saldo = 2000;
            conta.ContaCorrente = "12345";
            conta.Agencia = "7545";
            //conta.Banco = "Itau";

            // repository.Inserir(conta);
            #endregion

            #region Editar Conta
            Conta contaEditar  = new Conta();
            contaEditar.Id = 1;
            contaEditar.Limite = 100;
            //contaEditar.Nascimento = new DateTime(1978, 08, 30);
            //contaEditar.NomeTitular = "Souza";
            contaEditar.Saldo = 2000;
            contaEditar.ContaCorrente = "12345";
            contaEditar.Agencia = "7545";
            //contaEditar.Banco = "Itau";
            #endregion


            #region Apagar Conta
            // repository.Apagar(4);
            #endregion

            #region Obter apenas uma conta
            Conta conta_1 = repository.Obter(1);

            Console.WriteLine(conta_1);
            #endregion

            #region Editar Todas Contas
            IEnumerable<Conta> contas = repository.Obter();

            foreach (var item in contas)
            {
                Console.WriteLine(item.Agencia + " - " +  item.Banco + " - " + item.ContaCorrente + " - ");

            }

            #endregion

            #region Realizar Saque
            Conta contaSaque = repository.Obter(1);

            repository.RealizarSaque(contaSaque, 5);
            #endregion   
            
            #region Realizar Deposito
            Conta contaDeposito = repository.Obter(1);

            repository.RealizarDeposito(contaSaque, 5);
            #endregion 
            
            #region Fazer transferencia

            Conta contaOrigem = repository.Obter(1);
            Conta contaDestino = repository.Obter(2);

            repository.RealizarTransferencia(contaOrigem, contaDestino, 5);
            #endregion

            Console.ReadKey();

    

        }
    }
}
