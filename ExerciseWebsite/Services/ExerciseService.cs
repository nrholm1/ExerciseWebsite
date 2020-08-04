using ExerciseWebsite.Entities;
using ExerciseWebsite.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseWebsite.Services
{
    public interface IExerciseService
    {
        Exercise Create(Exercise Exercise);
        IEnumerable<Exercise> GetAll();
        Exercise GetById(int id);
        void Update(Exercise Exercise);
        void Delete(Exercise Exercise);
    }
    public class ExerciseService : IExerciseService
    {
        private DataContext _context;

        public ExerciseService(DataContext context)
        {
            _context = context;
        }

        public Exercise Create(Exercise Exercise)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<Exercise> GetAll()
        {
            throw new NotImplementedException();
        }

        public Exercise GetById(int id)
        {
            throw new NotImplementedException();
        }


        public void Update(Exercise Exercise)
        {
            throw new NotImplementedException();
        }
        public void Delete(Exercise Exercise)
        {
            throw new NotImplementedException();
        }
    }
}
