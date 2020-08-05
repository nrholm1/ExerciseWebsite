using System.Threading.Tasks;
using AutoMapper;
using ExerciseWebsite.Entities;
using ExerciseWebsite.Helpers;
using ExerciseWebsite.Models.Workout;
using ExerciseWebsite.Services;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;

namespace ExerciseWebsite.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WorkoutController : ControllerBase
    {
        private IWorkoutService _workoutService;
        private IMapper _mapper;
        public WorkoutController(IWorkoutService workoutService,
                                 IMapper mapper)
        {
            _workoutService = workoutService;
            _mapper = mapper;
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
        public async Task<IActionResult> Create([FromBody] CreateWorkout model)
        {
            var workout = _mapper.Map<Workout>(model);

            try
            {
                await _workoutService.Create(workout);
                return Ok();
            }
            catch (AppException ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }

        // PUT api/<WorkoutController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateWorkout model)
        {
            var workout = _mapper.Map<Workout>(model);
            workout.Id = id;

            try
            {
                await _workoutService.Update(workout);
                return Ok();
            }
            catch(AppException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPut("{id}/submitRating={newRating}")]
        public async Task<IActionResult> UpdateRating(int id, int newRating)
        {
            try
            {
                await _workoutService.UpdateRating(id, newRating);
                return Ok();
            }
            catch (AppException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        // DELETE api/<WorkoutController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _workoutService.Delete(id);
            return Ok();
        }
    }
}
