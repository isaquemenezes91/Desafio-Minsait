using Livraria.Models;
using Livraria.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Livraria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class LivrosController:ControllerBase
    {
        private readonly ILivroRepository _repository;
        public LivrosController(ILivroRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<Livro>> GetAll()
        {
            return await _repository.GetAll();
        }

        [HttpGet("{Nome}")]
        public async Task<ActionResult<Livro>> Get(string Nome)
        {
            return await _repository.Get(Nome);
        }

        [HttpPost]
        public async Task<ActionResult<Livro>> Create([FromBody]Livro livro)
        {
            var novoLivro = await _repository.Create(livro);
            return CreatedAtAction(nameof(GetAll),new {id = novoLivro.Id},novoLivro);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<Livro>> Delete(int Id)
        {
            var deleteLivro = await _repository.GetId(Id);
            if (deleteLivro == null)
            {
                return NotFound();
            }
           
            await _repository.Delete(deleteLivro.Id);
            
            return NoContent();
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult> Update(int Id, [FromBody] Livro livro)
        {
            if (Id == livro.Id)
            {
                return BadRequest();
            }

             
            await _repository.Update(livro);
           
            return NoContent();
        }
    }
}
