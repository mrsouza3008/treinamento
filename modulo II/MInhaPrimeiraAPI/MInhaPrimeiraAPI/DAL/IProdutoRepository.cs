using MInhaPrimeiraAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MInhaPrimeiraAPI.DAL
{
    public interface IProdutoRepository
    {
        void Adicionar(Produto produto);
        void Editar(Produto produto);
        void Apagar(Produto produto);
        Produto Obter(int id);
        IEnumerable<Produto> Obter();

    }
}
