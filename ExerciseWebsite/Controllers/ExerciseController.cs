using System.Threading.Tasks;
using AutoMapper;
using ExerciseWebsite.Entities;
using ExerciseWebsite.Helpers;
using ExerciseWebsite.Models.Exercise;
using ExerciseWebsite.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExerciseWebsite.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {
        private IExerciseService _exerciseService;
        private IMapper _mapper;
        public ExerciseController(IExerciseService exerciseService,
                                 IMapper mapper)
        {
            _exerciseService = exerciseService;
            _mapper = mapper;
        }

        // GET: api/<ExerciseController>
        [HttpGet]
        public IActionResult GetAll()
        {
            var exercises = _exerciseService.GetAll();
            return Ok(exercises);
        }

        // GET api/<ExerciseController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var exercise = await _exerciseService.GetById(id);
            return Ok(exercise);
        }

        // GET api/<ExerciseController>/5
        [HttpGet("name={nameQuery}")]
        public async Task<IActionResult> GetMostRelevantByName(string nameQuery)
        {
            var exercises = await _exerciseService.GetMostRelevantByName(nameQuery);
            return Ok(exercises);
        }

        // POST api/<ExerciseController>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ExerciseModel model)
        {
            var exercise = _mapper.Map<Exercise>(model);

            try
            {
                await _exerciseService.Create(exercise);
                return Ok();
            }
            catch (AppException ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] ExerciseModel model)
        {
            var exercise = _mapper.Map<Exercise>(model);
            exercise.Id = id;

            try
            {
                await _exerciseService.Update(exercise);
                return Ok();
            }
            catch (AppException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        // DELETE api/<ExerciseController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _exerciseService.Delete(id);
            return Ok();
        }
    }
}
