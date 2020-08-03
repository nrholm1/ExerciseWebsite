using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExerciseWebsite.Entities;
using ExerciseWebsite.Services;
using Microsoft.AspNetCore.Mvc;


namespace ExerciseWebsite.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {
        private IExerciseService _exerciseService;
        public ExerciseController(IExerciseService exerciseService)
        {
            _exerciseService = exerciseService;
        }

        // GET: api/<ExerciseController>
        //[HttpGet]
        //public IEnumerable<Exercise> GetAll()
        //{
        //    //return _exerciseService.
        //}

        // GET api/<ExerciseController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ExerciseController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ExerciseController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ExerciseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
