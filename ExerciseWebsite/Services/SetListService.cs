using ExerciseWebsite.Entities;
using ExerciseWebsite.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseWebsite.Services
{
    public interface ISetListService
    {
        Task<SetList> Create(SetList setList);
        Task<SetList> GetById(int id);
        IEnumerable<SetList> GetAll();
        IEnumerable<SetList> GetSetListsByWorkoutId(int workoutId);
        Task Update(SetList SetListParam);
        Task Delete(int id);
    }
    public class SetListService : ISetListService
    {
        private DataContext _context;

        public SetListService(DataContext context)
        {
            _context = context;
        }

        public async Task<SetList> Create(SetList setList)
        {
            // Check if already added?

            _context.SetLists.Add(setList);
            await _context.SaveChangesAsync();

            return setList;
        }

        public IEnumerable<SetList> GetAll()
        {
            return _context.SetLists;
        }

        public async Task<SetList> GetById(int id)
        {
            var setList = await _context.SetLists.FindAsync(id);

            if (setList != null)
                return setList;
            else
                throw new AppException($"No setList with id {id} found.");
        }

        // Smarter to get setLists themselves? Less roundtrips
        public IEnumerable<SetList> GetSetListsByWorkoutId(int workoutId)
        {
            var setLists = _context.SetLists.Where(x => x.WorkoutId == workoutId);
            return setLists.OrderBy(setList => setList.OrderNo);
        }

        public async Task Update(SetList setListParam)
        {
            var setList = await _context.SetLists.FindAsync(setListParam.Id);

            if (setList == null)
                throw new AppException($"No setList with id {setListParam.Id} found.");

            setList.OrderNo = setListParam.OrderNo;
            setList.SetId = setListParam.SetId;
            setList.WorkoutId = setListParam.WorkoutId;
            
            await _context.SaveChangesAsync();
        }


        public async Task Delete(int id)
        {
            var SetList = await _context.SetLists.FindAsync(id);

            if (SetList != null)
            {
                _context.SetLists.Remove(SetList);
                await _context.SaveChangesAsync();
            }
            else
                throw new AppException($"SetList with id {id} does not exist");
        }
    }
}
