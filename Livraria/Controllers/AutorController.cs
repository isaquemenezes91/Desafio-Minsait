using Livraria.Data.Context;
using Livraria.Data.Repositories;
using Livraria.Models;
using Livraria.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Livraria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly AutorRepository _repository;
        private readonly LogErroRepository _loger;
        private readonly string erroBadRequest = "Ocorreu uma falha interna, favor tente novamente mais tarde ou procure um dos nossos suportes!";


        public AutorController(LivrariaContext ctx)
        {
            _repository = new(ctx);
            _loger = new (ctx);
        }

        [HttpGet("{Id}")]
        public IActionResult BuscarIdAutor(int Id)
        {
            try
            {
                Autor autor = _repository.BuscarIdAutor(Id);

                if(autor == null)
                {
                    throw new ArgumentNullException();
                }
                return Ok(autor);
            }
            catch (Exception ex)
            {
                _loger.Adicionar(ex);

                return BadRequest(erroBadRequest);
            }
        }

        [HttpPost]
        public IActionResult AdicionarAutor([FromBody] AutorDto autor)
        {
            Autor resultado = new();

            try
            {
                resultado.LivroId = autor.LivroId;
                resultado.Nome = autor.Nome;

                _repository.AdicionarAutor(resultado);
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                _loger.Adicionar(ex);

                return BadRequest(erroBadRequest);
            }


        }

        [HttpPut("{Id}")]
        public IActionResult AtualizarAutor( int Id, AutorDto autor)
        {
            try
            {
                var autorBase = _repository.BuscarIdAutor(Id);

                if(autorBase == null)
                {
                    throw new ArgumentNullException();
                }
                autorBase.Nome = autor.Nome;
                _repository.AtualizarAutor(autorBase);
                return Ok(autorBase);
            }
            catch (Exception ex)
            {
                _loger.Adicionar(ex);

                return BadRequest(erroBadRequest);
            }
        }

        [HttpDelete("{Id}")]
        public IActionResult DeleteAutor(int Id)
        {
            try
            {
                var autorBase = _repository.BuscarIdAutor(Id);

                if(autorBase == null)
                {
                    throw new ArgumentNullException();
                }

                _repository.DeleteAutor(autorBase);
                _repository.SaveChanges();

                return Ok();
            }
            catch (Exception ex)
            {
                _loger.Adicionar(ex);

                return BadRequest(erroBadRequest);
            }
        }

    }
}
