using ExerciseWebsite.Entities;
using ExerciseWebsite.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExerciseWebsite.Services
{
    public interface ISetService
    {
        Task<Set> Create(Set Set);
        Task<Set> GetById(int id);
        IEnumerable<Set> GetAll();
        Task Update(Set SetParam);
        Task Delete(int id);

    }
    public class SetService : ISetService
    {
        private DataContext _context;

        public SetService(DataContext context)
        {
            _context = context;
        }

        public async Task<Set> Create(Set Set)
        {
            // Check if already added?

            _context.Sets.Add(Set);
            await _context.SaveChangesAsync();

            return Set;
        }

        public IEnumerable<Set> GetAll()
        {
            return _context.Sets;
        }

        public async Task<Set> GetById(int id)
        {
            var Set = await _context.Sets.FindAsync(id);

            if (Set != null)
                return Set;
            else
                throw new AppException($"No Set with id {id} found.");
        }

        public async Task Update(Set SetParam)
        {
            var Set = await _context.Sets.FindAsync(SetParam.Id);

            if (Set == null)
                throw new AppException($"No Set with id {SetParam.Id} found.");

            Set.ExerciseId = SetParam.ExerciseId;
            Set.RepCount = SetParam.RepCount;
            Set.SetCount = SetParam.SetCount;

            await _context.SaveChangesAsync();
        }


        public async Task Delete(int id)
        {
            var Set = await _context.Sets.FindAsync(id);

            if (Set != null)
            {
                _context.Sets.Remove(Set);
                await _context.SaveChangesAsync();
            }
            else
                throw new AppException($"Set with id {id} does not exist");
        }
    }
}
