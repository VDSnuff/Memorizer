using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Memorizer.Server.Data;
using Memorizer.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

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
        public Task<List<StudyingEntityWord>> Get()
        {
            _logger.LogInformation("{Time}: Get all words.", DateTime.UtcNow);
            return  _repository.GetAll();
        }

        // GET api/<WordController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StudyingEntityWord>> Get(long id)
        {
            _logger.LogInformation("{Time}: Get word by {id}.", DateTime.UtcNow, id);
            var result = await _repository.GetById(id);
            if (result == null) return NotFound();
            return result;
        }

        // POST api/<WordController>
        [HttpPost]
        public ActionResult<StudyingEntityWord> Post(StudyingEntityWord newStudyingEntityWord)
        {
            _repository.Add(newStudyingEntityWord);
            _repository.Commit();
            return CreatedAtAction("Post", new { id = newStudyingEntityWord.Id }, newStudyingEntityWord);
        }

        // PUT api/<WordController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<StudyingEntityWord>> Put(long id, StudyingEntityWord studyingEntityWord)
        {
            if (id != studyingEntityWord.Id) return BadRequest();
            await _repository.Update(studyingEntityWord);
            return await _repository.GetById(id);
        }

        // DELETE api/<WordController>/5
        [HttpDelete("{id}")]
        public ActionResult<Task<StudyingEntityWord>> Delete(long id)
        {
            if (_repository.GetById(id) == null) return NotFound();
            var studyingEntityWord = _repository.GetById(id);
            _repository.Delete(id);
            _repository.Commit();
            return studyingEntityWord;
        }
    }
}
