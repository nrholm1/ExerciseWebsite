using ExerciseWebsite.Entities;
using ExerciseWebsite.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseWebsite.Services
{
    public interface ISetService
    {
        Set Create(Set set);
        IEnumerable<Set> GetAll();
        IEnumerable<Set> GetBySetListId(int setListId);
        Set GetById(int id);
        void Update(Set set);
        void Delete(Set set);
    }
    public class SetService : ISetService
    {
        private DataContext _context;

        public SetService(DataContext context)
        {
            _context = context;
        }

        public Set Create(Set set)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<Set> GetAll()
        {
            throw new NotImplementedException();
        }

        public Set GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Set> GetBySetListId(int setListId)
        {
            throw new NotImplementedException();
        }

        public void Update(Set set)
        {
            throw new NotImplementedException();
        }
        public void Delete(Set set)
        {
            throw new NotImplementedException();
        }
    }
}
