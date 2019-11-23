using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using MInhaPrimeiraAPI.Models;
using MInhaPrimeiraAPI.Models.Validations;
using System.Collections.Generic;
using System.Linq;

namespace MInhaPrimeiraAPI.DAL
{
    public class ProdutoRepository : IProdutoRepository
    {

        public readonly APIContext _contexto;

        public ProdutoRepository(APIContext contexto)
        {
            _contexto = contexto;
        }

        public void Adicionar(Produto produto)
        {
        
                _contexto.Produtos.Add(produto);
                _contexto.SaveChanges();
     
        }

        public void Apagar(Produto produto)
        {
            _contexto.Produtos.Remove(produto);
            _contexto.SaveChanges();
        }

        public void Editar(Produto produto)
        {
            _contexto.Entry(produto).State = EntityState.Modified;
            _contexto.SaveChanges();
        }

        public Produto Obter(int id)
        {
            return _contexto.Produtos.Find(id);
           // return _contexto.Produtos.Where(a => a.Id == id).FirstOrDefault();    (Funciona dos dois modos)
        }

        public IEnumerable<Produto> Obter()
        {
            return _contexto.Produtos.ToList();
        }
    }
}
