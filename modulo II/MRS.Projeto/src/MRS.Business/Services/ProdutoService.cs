using MRS.Business.Interfaces;
using MRS.Business.Interfaces.Services;
using MRS.Business.Model;
using MRS.Business.Notificacoes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MRS.Business.Services
{
    public class ProdutoService : BaseService, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        
        public ProdutoService(IProdutoRepository produtoRepository, INotificador notificador)
            :base (notificador)
        {
            _produtoRepository = produtoRepository;
        }
        public async Task<bool> Apagar(Produto produto)
        {
            await _produtoRepository.Apagar(produto);
            return true;


        }

        public void Dispose()
        {
            _produtoRepository.Dispose();
        }

        public async Task<bool> Editar(Produto produto)
        {
            await _produtoRepository.Editar(produto);
            return true;
        }

        public async Task<bool> Inserir(Produto produto)
        {

            // if
                Notificar("Documento Invalido  - Isso é uma notificacao");
            // Return False
            

            await _produtoRepository.Inserir(produto);
            return true;
        }
    }
}
