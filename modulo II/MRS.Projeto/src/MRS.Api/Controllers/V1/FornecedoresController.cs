using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MRS.Api.ViewModel;
using MRS.Business.Interfaces;
using MRS.Business.Interfaces.Services;
using MRS.Business.Model;
using MRS.Business.Notificacoes;

namespace MRS.Api.Controllers.V1
{
    // [Route("api/v1/[controller]")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]

    public class FornecedoresController  : MainController
    {
        private readonly IFornecedorRepository _fornecedorRepository;
        private readonly IFornecedorService _fornecedorService;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public FornecedoresController
        (       IFornecedorRepository fornecedorRepository,
                IFornecedorService fornecedorService,
                IMapper mapper,
                INotificador notificador,
                ILogger<FornecedoresController> logger
        ) : base(notificador)
        {
            _fornecedorRepository = fornecedorRepository;
            _fornecedorService = fornecedorService;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        [ResponseCache(Duration = 20)]
        public async Task<ActionResult<IEnumerable<Fornecedor>>> GetFornecedores()
        {
            //_logger.Information($">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>  Fornecedor ID <<");
            return Ok(await _fornecedorRepository.Obter());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Fornecedor>> GetFornecedor(Guid id)
        {

            _logger.LogDebug( $">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>  Fornecedor ID - {id}");
            _logger.LogError( $">>> ERRO   >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>  Fornecedor ID - {id}");
            _logger.LogCritical( $">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>  Fornecedor ID - {id}");
            //_logger.Warning( $">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>  Fornecedor ID - {id}");
            //_logger.Information( $">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>  Fornecedor ID - {id}");

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