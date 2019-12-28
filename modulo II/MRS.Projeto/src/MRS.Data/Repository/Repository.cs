using Microsoft.EntityFrameworkCore;
using MRS.Business.Interfaces;
using MRS.Business.Model;
using MRS.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MRS.Data.Repository
{
    public class Repository<E> : IRepository<E> where E : Entity
    {
        private readonly Context.ApiContext _apiContext;
        public Repository(Context.ApiContext apiContext)
        {
            _apiContext = apiContext;
        }

        public async Task Inserir(E entity)
        {
            _apiContext.Add(entity);
            await _apiContext.SaveChangesAsync();
        }

        public async Task Apagar(E entity)
        {
            _apiContext.Remove(entity);
            await _apiContext.SaveChangesAsync();
        }

        public async Task Editar(E entity)
        {
            _apiContext.Entry(entity).State =  EntityState.Modified;
            await _apiContext.SaveChangesAsync();

        }



        public async Task<E> Obter(Guid id)
        {
            return await _apiContext.Set<E>().FindAsync(id);
        }

        public async Task<IEnumerable<E>> Obter()
        {
            return await _apiContext.Set<E>().ToListAsync();
        }

        public void Dispose()
        {
            _apiContext.Dispose();
        }

    }
}
