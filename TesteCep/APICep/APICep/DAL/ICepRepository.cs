using APICep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICep.DAL
{
    public interface ICepRepository
    {
        void Adicionar(Cep cep);
        void Editar(Cep cep);
        void Apagar(Cep cep);
        Cep Obter(string codigo);
        IEnumerable<Cep> Obter();


    }
}
