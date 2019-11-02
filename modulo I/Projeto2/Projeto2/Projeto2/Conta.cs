using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    public class Conta
    {
        public int Id { get; set; }
        public int BancoId { get; set; }
        public Banco Banco { get; set; }   // Link de navegacao 

        //public string Banco { get; set; }
        public string  Agencia { get; set; }
        public string ContaCorrente { get; set; }
        public decimal Saldo { get; set; }
        public decimal Limite { get; set; }
        public int ClientId { get; set; }
        public Cliente Cliente { get; set; } // Link de navegacao 

        public override string ToString()
        {
            // return $"{Banco} - {Saldo}";
            return $"Id={Id} - Conta Corrente={ContaCorrente} - Saldo={Saldo}";
        }
    }    

    

}
