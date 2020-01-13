using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MRS.Api.ViewModel;
using MRS.Business.Interfaces;
using MRS.Business.Interfaces.Services;
using MRS.Business.Model;
using MRS.Business.Notificacoes;
using MRS.Data.Context;

namespace MRS.Api.Controllers.V1
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
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
        [ResponseCache(Duration = 20)]
        public async Task<ActionResult<IEnumerable<ProdutoViewModel>>> Get()
        {
            return Ok(await _produtoRepository.Obter());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProdutoViewModel>> Get(Guid id)
        {
            var produto = await _produtoRepository.Obter(id);

            if (produto == null)
            {
                return NotFound();
            }

            return _mapper.Map<ProdutoViewModel>(produto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, ProdutoEditarViewModel produtoVM)
        {
            if (!ModelState.IsValid) return Result(ModelState);

            if (id != produtoVM.Id)
            {
                return BadRequest();
            }

            await _produtoService.Editar(_mapper.Map<Produto>(produtoVM));

            return Result("Registro alterado com sucesso");
        }

        [HttpPost]
        public async Task<ActionResult<Produto>> Post(ProdutoAdicionarViewModel produtoVM)
        {
            if (!ModelState.IsValid) return Result(ModelState);

            var nomeImagem = $"{Guid.NewGuid()}.jpg";
            if (!UploadImagem(produtoVM.Imagem, nomeImagem))
            {
                return Result();
            };
            produtoVM.Imagem = nomeImagem;

            var prod = _mapper.Map<Produto>(produtoVM);

            await _produtoService.Inserir(prod);

            return Result("Regitro incluido com sucesso");
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

            return Result("Registro apagado com sucesso");
        }

        private bool UploadImagem(string imagemBase64, string nomeImagem)
        {
            if (string.IsNullOrEmpty(imagemBase64))
            {
                NotificarErro("É necessário informar uma imagem para o produto");
                return false;
            }

            var imagemByte = Convert.FromBase64String(imagemBase64);

            var pathImagem = Path.Combine("D:","TEMP", nomeImagem);

            System.IO.File.WriteAllBytes(pathImagem, imagemByte);

            return true;
        }
    }

}
