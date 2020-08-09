using System.Threading.Tasks;
using AutoMapper;
using ExerciseWebsite.Entities;
using ExerciseWebsite.Helpers;
using ExerciseWebsite.Models.SetList;
using ExerciseWebsite.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExerciseWebsite.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SetListController : ControllerBase
    {
        private ISetListService _setListService;
        private IMapper _mapper;
        public SetListController(ISetListService setListService,
                                 IMapper mapper)
        {
            _setListService = setListService;
            _mapper = mapper;
        }

        // GET: api/<SetListController>
        [HttpGet]
        public IActionResult GetAll()
        {
            var setLists = _setListService.GetAll();
            return Ok(setLists);
        }

        // GET api/<SetListController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var setList = await _setListService.GetById(id);
            return Ok(setList);
        }

        // POST api/<setListController>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] SetListModel model)
        {
            var setList = _mapper.Map<SetList>(model);

            try
            {
                await _setListService.Create(setList);
                return Ok();
            }
            catch (AppException ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] SetListModel model)
        {
            var setList = _mapper.Map<SetList>(model);
            setList.Id = id;

            try
            {
                await _setListService.Update(setList);
                return Ok();
            }
            catch (AppException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        // DELETE api/<SetListController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _setListService.Delete(id);
            return Ok();
        }
    }
}
