using ExerciseWebsite.Entities;
using ExerciseWebsite.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseWebsite.Services
{
    public interface IWorkoutService
    {
        Workout Create(Workout workout);
        Workout GetById(int id);
        IEnumerable<Workout> GetAll();
        void Update(Workout workoutParam);
        void UpdateAvgDifficulty(int id, double avgDifficulty);
        void Delete(int id);

    }
    public class WorkoutService : IWorkoutService
    {
        private DataContext _context;

        public WorkoutService(DataContext context)
        {
            _context = context;
        }

        public Workout Create(Workout workout)
        {
            // Check if already added?

            _context.Workouts.Add(workout);
            _context.SaveChanges();

            return workout;
        }

        public IEnumerable<Workout> GetAll()
        {
            return _context.Workouts;
        }

        public Workout GetById(int id)
        {
            var workout = _context.Workouts.Find(id);

            if (workout != null)
                return workout;
            else
                throw new AppException($"No workout with id {id} found.");
        }

        public void Update(Workout workoutParam)
        {
            var workout = _context.Workouts.Find(workoutParam.Id);

            if (workout == null)
                throw new AppException($"No workout with id {workoutParam.Id} found.");


            workout.Title = workoutParam.Title;
            workout.Description = workoutParam.Description;

            _context.SaveChanges();
        }

        public void UpdateAvgDifficulty(int id, double avgDifficulty)
        {
            var workout = _context.Workouts.Find(id);
            
            if (workout == null)
                throw new AppException($"No workout with id {id} found.");

            workout.AvgDifficulty = avgDifficulty;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var workout = _context.Workouts.Find(id);

            if (workout != null)
            {
                _context.Workouts.Remove(workout);
                _context.SaveChanges();
            }
            else
                throw new AppException($"Workout with id {id} does not exist");
        }
    }
}
