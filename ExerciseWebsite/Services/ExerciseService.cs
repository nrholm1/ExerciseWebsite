using ExerciseWebsite.Entities;
using ExerciseWebsite.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExerciseWebsite.Services
{
    public interface IExerciseService
    {
        Task<Exercise> Create(Exercise exercise);
        Task<Exercise> GetById(int id);
        IEnumerable<Exercise> GetAll();
        Task Update(Exercise exerciseParam);
        Task Delete(int id);

    }
    public class ExerciseService : IExerciseService
    {
        private DataContext _context;

        public ExerciseService(DataContext context)
        {
            _context = context;
        }

        public async Task<Exercise> Create(Exercise exercise)
        {
            // Check if already added?

            _context.Exercises.Add(exercise);
            await _context.SaveChangesAsync();

            return exercise;
        }

        public IEnumerable<Exercise> GetAll()
        {
            return _context.Exercises;
        }

        public async Task<Exercise> GetById(int id)
        {
            var exercise = await _context.Exercises.FindAsync(id);

            if (exercise != null)
                return exercise;
            else
                throw new AppException($"No exercise with id {id} found.");
        }

        public async Task Update(Exercise exerciseParam)
        {
            var exercise = await _context.Exercises.FindAsync(exerciseParam.Id);

            if (exercise == null)
                throw new AppException($"No exercise with id {exerciseParam.Id} found.");

            exercise.Description = exerciseParam.Description;
            exercise.Difficulty = exerciseParam.Difficulty;
            exercise.ExType = exerciseParam.ExType;
            exercise.MuscleGroup = exerciseParam.MuscleGroup;
            exercise.Name = exerciseParam.Name;

            await _context.SaveChangesAsync();
        }


        public async Task Delete(int id)
        {
            var Exercise = await _context.Exercises.FindAsync(id);

            if (Exercise != null)
            {
                _context.Exercises.Remove(Exercise);
                await _context.SaveChangesAsync();
            }
            else
                throw new AppException($"Exercise with id {id} does not exist");
        }
    }
}
