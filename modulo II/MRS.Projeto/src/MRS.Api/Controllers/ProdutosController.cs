using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MRS.Business.Interfaces;
using MRS.Business.Interfaces.Services;
using MRS.Business.Model;
using MRS.Business.Notificacoes;
using MRS.Data.Context;

namespace MRS.Api.Controllers
{
    [Route("api/[controller]")]

    public class ProdutosController : MainController
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IProdutoService _produtoService;
        private readonly IMapper _mapper;

        public ProdutosController
        (
                IProdutoRepository produtoRepository,
                IProdutoService produtoService,
                IMapper mapper,
                INotificador notificador
        ) : base(notificador)

        {
            _produtoRepository = produtoRepository;
            _produtoService = produtoService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> Get()
        {
            return Ok(await _produtoRepository.Obter());
        }

        public async Task<ActionResult<Produto>> Get(Guid id)
        {
            var produto = await _produtoRepository.Obter(id);

            if (produto == null)
            {
                return NotFound();
            }

            return produto;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, Produto produto)
        {
            if (id != produto.Id)
            {
                return BadRequest();
            }

            await _produtoService.Editar(produto);

            return Result();
        }

        [HttpPost]
        public async Task<ActionResult<Produto>> Post(Produto produto)
        {
            await _produtoService.Inserir(produto);

            //return CreatedAtAction("Post", new { id = produto.Id }, produto);
            return Result();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Produto>> Delete(Guid id)
        {
            var produto = await _produtoRepository.Obter(id);
            if (produto == null)
            {
                return NotFound();
            }

            await _produtoService.Apagar(produto);

            // return produto;
            return Result();
        }
    }
}
