using System.Threading.Tasks;
using AutoMapper;
using ExerciseWebsite.Entities;
using ExerciseWebsite.Helpers;
using ExerciseWebsite.Models.Set;
using ExerciseWebsite.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExerciseWebsite.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SetController : ControllerBase
    {
        private ISetService _setService;
        private IMapper _mapper;
        public SetController(ISetService SetService,
                                 IMapper mapper)
        {
            _setService = SetService;
            _mapper = mapper;
        }

        // GET: api/<SetController>
        [HttpGet]
        public IActionResult GetAll()
        {
            var Sets = _setService.GetAll();
            return Ok(Sets);
        }

        // GET api/<SetController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var Set = await _setService.GetById(id);
            return Ok(Set);
        }

        // POST api/<SetController>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] SetModel model)
        {
            var Set = _mapper.Map<Set>(model);

            try
            {
                await _setService.Create(Set);
                return Ok();
            }
            catch (AppException ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateSet model)
        {
            var Set = _mapper.Map<Set>(model);
            Set.Id = id;

            try
            {
                await _setService.Update(Set);
                return Ok();
            }
            catch (AppException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        // DELETE api/<SetController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _setService.Delete(id);
            return Ok();
        }
    }
}
