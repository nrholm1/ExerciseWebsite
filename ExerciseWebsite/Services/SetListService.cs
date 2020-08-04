using ExerciseWebsite.Entities;
using ExerciseWebsite.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseWebsite.Services
{
    public interface ISetListService
    {
        SetList Create(SetList SetList);
        IEnumerable<SetList> GetAll();
        SetList GetById(int id);
        void Update(SetList SetList);
        void Delete(SetList SetList);
    }
    public class SetListService : ISetListService
    {
        private DataContext _context;

        public SetListService(DataContext context)
        {
            _context = context;
        }

        public SetList Create(SetList SetList)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<SetList> GetAll()
        {
            throw new NotImplementedException();
        }

        public SetList GetById(int id)
        {
            throw new NotImplementedException();
        }


        public void Update(SetList SetList)
        {
            throw new NotImplementedException();
        }
        public void Delete(SetList SetList)
        {
            throw new NotImplementedException();
        }
    }
}
