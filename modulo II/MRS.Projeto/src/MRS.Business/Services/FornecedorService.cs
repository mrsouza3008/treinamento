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
    public class FornecedorService : BaseService,  IFornecedorService
    { 
        private readonly IFornecedorRepository _fornecedorRepository;

        public FornecedorService(IFornecedorRepository fornecedorRepository, INotificador notificador)
            : base(notificador)
        {
            _fornecedorRepository = fornecedorRepository;
        }
    
        public async Task<bool> Apagar(Fornecedor fornecedor)
        {
            await _fornecedorRepository.Apagar(fornecedor);
            return true;
        }

        public void Dispose()
        {
            _fornecedorRepository.Dispose();
        }

        public async Task<bool> Editar(Fornecedor fornecedor)
        {
            await _fornecedorRepository.Editar(fornecedor);
            return true;
        }

        public async Task<bool> Inserir(Fornecedor fornecedor)
        {

            Notificar("Minha notificacao de Inserir Fornecedor");
             
            await _fornecedorRepository.Inserir(fornecedor);
            return true;

        }
    }
}
