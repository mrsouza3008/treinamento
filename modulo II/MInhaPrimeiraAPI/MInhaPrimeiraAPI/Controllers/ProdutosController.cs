using AutoMapper;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using MInhaPrimeiraAPI.DAL;
using MInhaPrimeiraAPI.Models;
using MInhaPrimeiraAPI.Models.Validations;
using MInhaPrimeiraAPI.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace MInhaPrimeiraAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        public readonly IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;

        public ProdutosController(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public ActionResult<Produto> AdicionarProduto(ProdutoAdicionarViewModel produtoVM)
        {

           var prd =  _mapper.Map<Produto>(produtoVM);

            /*
              Produto produto = new Produto();
              produto.Descricao = produtoVM.Descricao;
              produto.Valor = produtoVM.Valor;
              */

            ValidationResult resultadoValidacao = new ProdutoValidation().Validate(prd);

            if (!resultadoValidacao.IsValid)
            {
                return BadRequest(new
                {
                    erro = resultadoValidacao.Errors.Select(a => a.ErrorMessage)
                });
            }

            _produtoRepository.Adicionar(prd);
            return Created(nameof(AdicionarProduto), new { IdCadastrado = prd.Id });
        }

        [HttpPut("{id}")]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]

        public ActionResult<Produto> Editar(ProdutoEditarViewModel produtoVM)
        {
            var prd = _mapper.Map<Produto>(produtoVM);

            _produtoRepository.Editar(prd);

            return NoContent(); // retorna 204 
        }


        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]

        public ActionResult<Produto> Apagar(int id)
        {
            var produto = _produtoRepository.Obter(id);
            _produtoRepository.Apagar(produto);
            return NoContent(); // retorna 204
        }



        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]

        public ActionResult<Produto> Obter(int id)
        {
           var produto =  _produtoRepository.Obter(id);

            if (produto == null)
                // return NotFound($" Id {id} não foi encontrado!");
                return NotFound(new { mensagem = $" Id {id} não foi encontrado!" });
            else
                return Ok(produto);
        }


        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]

        public ActionResult<IEnumerable<Produto>> Obter()
        {
            var produtos =  _produtoRepository.Obter();
            return Ok(produtos);
            
        }
    }
}