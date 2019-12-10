using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APICep.Models;
using Microsoft.EntityFrameworkCore;

namespace APICep.DAL
{
    public class CepRepository : ICepRepository
    {

        public readonly APIContext _contexto;

        public CepRepository(APIContext contexto)
        {
            _contexto = contexto;
        }

        public void Adicionar(Cep cep)
        {
            _contexto.Ceps.Add(cep);
            _contexto.SaveChanges();
        }

        public void Apagar(Cep cep)
        {
            _contexto.Ceps.Remove(cep);
            _contexto.SaveChanges();
        }

        public void Editar(Cep cep)
        {
            _contexto.Entry(cep).State = EntityState.Modified;
            _contexto.SaveChanges();

        }

        public Cep Obter(string codigo)
        {
            return _contexto.Ceps.Find(codigo);
        }

        public IEnumerable<Cep> Obter()
        {
            return _contexto.Ceps.ToList();
        }
    }
}
