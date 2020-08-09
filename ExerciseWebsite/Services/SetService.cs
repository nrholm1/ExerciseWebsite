using ExerciseWebsite.Entities;
using ExerciseWebsite.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExerciseWebsite.Services
{
    public interface ISetService
    {
        Task<Set> Create(Set set);
        Task<Set> GetById(int id);
        IEnumerable<Set> GetAll();
        Task Update(Set setParam);
        Task Delete(int id);

    }
    public class SetService : ISetService
    {
        private DataContext _context;

        public SetService(DataContext context)
        {
            _context = context;
        }

        public async Task<Set> Create(Set set)
        {
            // Check if already added?

            _context.Sets.Add(set);
            await _context.SaveChangesAsync();

            return set;
        }

        public IEnumerable<Set> GetAll()
        {
            return _context.Sets;
        }

        public async Task<Set> GetById(int id)
        {
            var set = await _context.Sets.FindAsync(id);

            if (set != null)
                return set;
            else
                throw new AppException($"No set with id {id} found.");
        }

        public async Task Update(Set setParam)
        {
            var set = await _context.Sets.FindAsync(setParam.Id);

            if (set == null)
                throw new AppException($"No set with id {setParam.Id} found.");

            set.ExerciseId = setParam.ExerciseId;
            set.RepCount = setParam.RepCount;
            set.SetCount = setParam.SetCount;

            await _context.SaveChangesAsync();
        }


        public async Task Delete(int id)
        {
            var set = await _context.Sets.FindAsync(id);

            if (set != null)
            {
                _context.Sets.Remove(set);
                await _context.SaveChangesAsync();
            }
            else
                throw new AppException($"Set with id {id} does not exist");
        }
    }
}
