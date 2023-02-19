using Livraria.Data;
using Livraria.Models;
using Livraria.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Livraria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AutorController:ControllerBase
    {
        private readonly AutorRepository _repository;
        public AutorController(LivrariaContext repository)
        {
            _repository = new(repository);
        }

        [HttpGet]
        public async Task<IEnumerable<Autor>> GetAll()
        {
            return await _repository.GetAll();
        }

        [HttpGet("{Nome}")]
        public async Task<ActionResult<Autor>> Get(string Nome)
        {
            return await _repository.Get(Nome);
        }

        [HttpPost]
        public async Task<ActionResult<Autor>> Create([FromBody]Autor autor)
        {
            var novoAutor = await _repository.Create(autor);
            return CreatedAtAction(nameof(GetAll),new {id = novoAutor.Id},novoAutor);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<Autor>> Delete(int Id)
        {
            var deleteAutor = await _repository.GetId(Id);
            if (deleteAutor == null)
            {
                return NotFound();
            }
           
            await _repository.Delete(deleteAutor.Id);
            
            return NoContent();
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult> Update(int Id, [FromBody] Autor autor)
        {
            if (Id == autor.Id)
            {
                return BadRequest();
            }

             
            await _repository.Update(autor);
           
            return NoContent();
        }
    }
}
