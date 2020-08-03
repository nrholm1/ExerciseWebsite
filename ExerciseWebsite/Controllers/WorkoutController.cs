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
    public class WorkoutController : ControllerBase
    {
        private IWorkoutService _workoutService;
        public WorkoutController(IWorkoutService workoutService)
        {
            _workoutService = workoutService;
        }

        // GET: api/<WorkoutController>
        [HttpGet]
        public IActionResult GetAll()
        {
            var workouts = _workoutService.GetAll();
            return Ok(workouts);
        }

        // GET api/<WorkoutController>/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var workout = _workoutService.GetById(id);
            return Ok(workout);
        }

        // POST api/<WorkoutController>
        [HttpPost]
        public void Create([FromBody] Workout workout)
        {

        }

        // PUT api/<WorkoutController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WorkoutController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
