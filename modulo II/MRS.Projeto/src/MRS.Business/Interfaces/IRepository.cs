using MRS.Business.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MRS.Business.Interfaces
{
    public interface IRepository<E> : IDisposable where  E : Entity
    {
        Task Inserir(E entity);
        Task Editar(E entity);
        Task Apagar(E entity);
        Task<E> Obter(Guid id);
        Task<IEnumerable<E>> Obter();
    }
}
