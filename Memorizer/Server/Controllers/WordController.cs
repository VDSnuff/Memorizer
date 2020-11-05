using Memorizer.Server.Data;
using Memorizer.Server.Helpers;
using Memorizer.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Memorizer.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordController : ControllerBase
    {
        private readonly IStudyingEntityWordRepository _repository;
        private readonly ILogger<WordController> _logger;

        public WordController(IStudyingEntityWordRepository repository, ILogger<WordController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] QueryParamiters queryParamiters)
        {
            _logger.LogInformation("{Time}: Get all words.", DateTime.UtcNow);
            return Ok(await _repository.GetAllAsync(queryParamiters));
        }

        // GET api/<WordController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            _logger.LogInformation("{Time}: Get word by {id}.", DateTime.UtcNow, id);
            var result = await _repository.GetByIdAsync(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        // POST api/<WordController>
        [HttpPost]
        public async Task<ActionResult<StudyingEntityWord>> Post([FromBody] StudyingEntityWord newStudyingEntityWord)
        {
            _logger.LogInformation("{Time}: Add new word.", DateTime.UtcNow);
            _repository.Add(newStudyingEntityWord);
            await _repository.CommitAsync();
            return CreatedAtAction("Get", new { id = newStudyingEntityWord.Id }, newStudyingEntityWord);
        }

        // PUT api/<WordController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(long id, StudyingEntityWord studyingEntityWord)
        {
            _logger.LogInformation("{Time}: Update word by {id}.", DateTime.UtcNow, id);
            if (id != studyingEntityWord.Id) return BadRequest();
             _repository.Update(studyingEntityWord);
            await _repository.CommitAsync();
            return Ok(await _repository.GetByIdAsync(id));
        }

        // DELETE api/<WordController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            _logger.LogInformation("{Time}: Delete word by Id: {id}.", DateTime.UtcNow, id);
            var studyingEntityWord = await _repository.GetByIdAsync(id);
            if (studyingEntityWord == null) return NotFound();  
            await _repository.DeleteAsync(id);
            await _repository.CommitAsync();
            return Ok(studyingEntityWord);
        }
    }
}
