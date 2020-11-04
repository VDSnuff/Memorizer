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
            return Ok(await _repository.GetAll(queryParamiters));
        }

        // GET api/<WordController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            _logger.LogInformation("{Time}: Get word by {id}.", DateTime.UtcNow, id);
            var result = await _repository.GetById(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        // POST api/<WordController>
        [HttpPost]
        public async Task<ActionResult<StudyingEntityWord>> Post([FromBody] StudyingEntityWord newStudyingEntityWord)
        {
            _logger.LogInformation("{Time}: Add new word.", DateTime.UtcNow);
            await _repository.Add(newStudyingEntityWord);
            return CreatedAtAction("Get", new { id = newStudyingEntityWord.Id }, newStudyingEntityWord);
        }

        // PUT api/<WordController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(long id, StudyingEntityWord studyingEntityWord)
        {
            _logger.LogInformation("{Time}: Update word by {id}.", DateTime.UtcNow, id);
            if (id != studyingEntityWord.Id) return BadRequest();
            await _repository.Update(studyingEntityWord);
            var result = _repository.GetById(id);
            return Ok(result);
        }

        // DELETE api/<WordController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _logger.LogInformation("{Time}: Delete word by {id}.", DateTime.UtcNow, id);
            if (_repository.GetById(id) == null) return NotFound();
            var studyingEntityWord = _repository.GetById(id);
            _repository.Delete(id);
            _repository.Commit();
            return Ok(studyingEntityWord);
        }
    }
}
