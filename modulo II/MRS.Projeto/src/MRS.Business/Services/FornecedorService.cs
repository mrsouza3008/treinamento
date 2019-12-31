using FluentValidation.Results;
using MRS.Business.Interfaces;
using MRS.Business.Interfaces.Services;
using MRS.Business.Model;
using MRS.Business.Notificacoes;
using MRS.Business.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
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

       

        public async Task<bool> Editar(Fornecedor fornecedor)
        {

            //Validar se o documento é valido
            new FornecedorValidation().Validate(fornecedor);

            // valida se ja existe o fornecedor com esse documento
            if (_fornecedorRepository.Buscar(f => f.Documento == fornecedor.Documento && f.Id != fornecedor.Id).Result.Any()) // retorna verdadeiro se existe o documento
            {
                Notificar("Já existe um fornecedor com este documento");
                return false;
            }


            await _fornecedorRepository.Editar(fornecedor);
            return true;
        }

        public async Task<bool> Inserir(Fornecedor fornecedor)
        {

            //Validar se o documento é valido
            if (EfetuarValidacao(new FornecedorValidation(), fornecedor))
            {
                return false;
            }


            // valida se ja existe o fornecedor com esse documento
            if (_fornecedorRepository.Buscar(f => f.Documento == fornecedor.Documento).Result.Any()) // retorna verdadeiro se existe o documento
            {
                Notificar("Já existe um fornecedor com este documento");
                return false;
            }


            await _fornecedorRepository.Inserir(fornecedor);
            return true;

        }

        public void Dispose()
        {
            _fornecedorRepository.Dispose();
        }
    }
}
