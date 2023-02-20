using Livraria.Data.Context;
using Livraria.Data.Repositories;
using Livraria.Manager.Interfaces;
using Livraria.Models;
using Livraria.Models.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace Livraria.Controllers
{
    [Route("v1/api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {

        private readonly LivroRepository _livroRepository;
        private readonly LogErroRepository _logRepository;
        private readonly string erroBadRequest = "Ocorreu uma falha interna, favor tente novamente mais tarde ou procure um dos nossos suportes!";

        public LivroController(LivrariaContext ctx)
        {
            _livroRepository = new(ctx);

            _logRepository = new(ctx);
        }

        [HttpGet]
        public IActionResult Buscar()
        {
            List<LivroDto> retorno = new();
            try
            {
                var resultado = _livroRepository.Buscar();
                if (resultado.Count() > 0)
                {
                    foreach (Livro livro in resultado)
                    {
                        LivroDto dto = new();

                        dto.Id = livro.Id;
                        dto.Titulo = livro.Titulo;
                        dto.Subtitulo = livro.Subtitulo;
                        dto.Resumo = livro.Resumo;
                        dto.DataPublicacao = livro.DataPublicacao.ToShortDateString();
                        dto.QuantidadePaginas = livro.QuantidadePaginas;
                        dto.Editora = livro.Editora;
                        dto.Edicao = livro.Edicao;
                        dto.QuantidadeEstoque = livro.QuantidadeEstoque;
                        dto.Autores = livro.Autores;

                        retorno.Add(dto);
                    }
                }

                return Ok(retorno);
            }
            catch(Exception ex)
            {
                _logRepository.Adicionar(ex);
                return BadRequest(erroBadRequest);
            }
        }

        [HttpPost]
        public ActionResult Adicionar(LivroDto dto)
        {
            Livro livro = new Livro();
            try
            {
                
                livro.Titulo = dto.Titulo;
                livro.Subtitulo = dto.Subtitulo;
                livro.Resumo = dto.Resumo;
                livro.DataPublicacao = Convert.ToDateTime(dto.DataPublicacao);
                livro.QuantidadePaginas = dto.QuantidadePaginas;
                livro.Editora = dto.Editora;
                livro.Edicao = dto.Edicao;
                livro.QuantidadeEstoque = dto.QuantidadeEstoque;
                livro.Autores = dto.Autores;

                _livroRepository.Adicionar(livro);
                return Ok(livro);
            }
            catch(Exception ex)
            {
                _logRepository.Adicionar(ex);
                return BadRequest(erroBadRequest);
            }
        }

        [HttpPut("{Id}")]
        public IActionResult Atualizar(int Id, LivroDto livro)
        {
            try
            {
                var livroBase =  _livroRepository.BuscarId(Id);
                if (livroBase == null)
                {
                    return BadRequest($"Id: {Id} não foi encontrado!");
                }

                livroBase.Titulo = livro.Titulo;
                livroBase.Subtitulo = livro.Subtitulo;
                livroBase.Resumo = livro.Resumo;
                livroBase.DataPublicacao = Convert.ToDateTime(livro.DataPublicacao);
                livroBase.QuantidadePaginas = livro.QuantidadePaginas;
                livroBase.Editora = livro.Editora;
                livroBase.Edicao = livro.Edicao;
                livroBase.QuantidadeEstoque = livro.QuantidadeEstoque;
                livroBase.Autores = livro.Autores;

                _livroRepository.Atualizar(livroBase);

                return Ok();
            }
            catch (Exception ex)
            {
                _logRepository.Adicionar(ex);
                return BadRequest(erroBadRequest);
            }

        }

        [HttpDelete("{id}")]
        public IActionResult Remover(int id)
        {
            try
            {
                var livroBase = _livroRepository.BuscarId(id);

                if (livroBase == null)
                    return BadRequest($"Id: {id} não foi encontrado!");

                _livroRepository.Delete(livroBase);
                _livroRepository.SaveChanges();

                return Ok();
            }
            catch (Exception ex)
            {
                _logRepository.Adicionar(ex);
                return BadRequest(erroBadRequest);
            }
        }

        [HttpGet("{id}")]
        public IActionResult BuscarId(int id)
        {
            Livro livro = new();
            try
            {
                livro = _livroRepository.BuscarId(id);
                if(livro == null)
                {
                    return BadRequest($"Id: {id} não foi encontrado!");
                }
                return Ok(livro);
            }
            catch (Exception ex)
            {
                _logRepository.Adicionar(ex);
                return BadRequest(erroBadRequest);
            }
        }



    }
}
