using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Memorizer.Server.Data;
using Memorizer.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Memorizer.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordController : ControllerBase
    {
        private readonly IStudyingEntityWordRepository _repository;
        private readonly ILogger<StudyingEntityWord> _logger;

        public WordController(IStudyingEntityWordRepository repository, ILogger<StudyingEntityWord> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet]
        public List<StudyingEntityWord> Get()
        {
            return  _repository.GetAll();
        }

        // GET api/<WordController>/5
        [HttpGet("{id}")]
        public ActionResult<StudyingEntityWord> Get(int id)
        {
            if (_repository.GetById(id) == null) return NotFound();
            return _repository.GetById(id);
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
        public void Put(StudyingEntityWord studyingEntityWord)
        {
            _repository.Update(studyingEntityWord);
            _repository.Commit();
        }

        // DELETE api/<WordController>/5
        [HttpDelete("{id}")]
        public ActionResult<StudyingEntityWord> Delete(int id)
        {
            if (_repository.GetById(id) == null) return NotFound();
            var studyingEntityWord = _repository.GetById(id);
            _repository.Delete(id);
            _repository.Commit();
            return studyingEntityWord;
        }
    }
}
