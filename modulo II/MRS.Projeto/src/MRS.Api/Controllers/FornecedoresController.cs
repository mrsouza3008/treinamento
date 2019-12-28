using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MRS.Api.ViewModel;
using MRS.Business.Interfaces;
using MRS.Business.Interfaces.Services;
using MRS.Business.Model;
using MRS.Business.Notificacoes;

namespace MRS.Api.Controllers
{
    [Route("api/[controller]")]
   
    public class FornecedoresController  : MainController
    {
        private readonly IFornecedorRepository _fornecedorRepository;
        private readonly IFornecedorService _fornecedorService;
        private readonly IMapper _mapper;

        public FornecedoresController
        (       IFornecedorRepository fornecedorRepository,
                IFornecedorService fornecedorService,
                IMapper mapper,
                INotificador notificador
        ) : base(notificador)
        {
            _fornecedorRepository = fornecedorRepository;
            _fornecedorService = fornecedorService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fornecedor>>> GetFornecedores()
        {
            return Ok(await _fornecedorRepository.Obter());
        }

        public async Task<ActionResult<Fornecedor>> GetFornecedor(Guid id)
        {
            var fornecedor = await _fornecedorRepository.Obter(id);

            if (fornecedor == null)
            {
                return NotFound();
            }

            return fornecedor;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutFornecedor(Guid id, Fornecedor fornecedor)
        {
            if (!ModelState.IsValid) return Result(ModelState);

            if (id != fornecedor.Id)
            {
                return BadRequest();
            }

            await _fornecedorService.Editar(fornecedor);

            return Result();
        }

        [HttpPost]
        public async Task<ActionResult<Fornecedor>> PostFornecedor(FornecedorAdicionarViewModel fornecedor)
        {
            if (!ModelState.IsValid) return Result(ModelState);

            await _fornecedorService.Inserir(_mapper.Map<Fornecedor>(fornecedor));
            return Result("Fornecedor Incluido com Sucesso");

            //return CreatedAtAction("GetFornecedor", new { id = fornecedor.Id }, fornecedor);
          
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Fornecedor>> DeleteFornecedor(Guid id)
        {
            var fornecedor = await _fornecedorRepository.Obter(id);
            if (fornecedor == null)
            {
                return NotFound();
            }

            await _fornecedorService.Apagar(fornecedor);

            return Result();
        }
    }
}