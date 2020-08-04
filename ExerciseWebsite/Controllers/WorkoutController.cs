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
        public async Task<IActionResult> GetAll()
        {
            var workouts = await _workoutService.GetAllAsync();
            return Ok(workouts);
        }

        // GET api/<WorkoutController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var workout = await _workoutService.GetById(id);
            return Ok(workout);
        }

        // POST api/<WorkoutController>
        [HttpPost]
        public async void Create([FromBody] Workout workout)
        {

        }

        // PUT api/<WorkoutController>/5
        [HttpPut("{id}")]
        public async void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WorkoutController>/5
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
        }
    }
}
