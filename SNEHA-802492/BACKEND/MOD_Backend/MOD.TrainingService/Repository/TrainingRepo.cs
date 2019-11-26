using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.TrainingService.Context;
using MOD.TrainingService.Models;

namespace MOD.TrainingService.Repository
{
    public class TrainingRepo : TrainingRepository
    {
        public readonly TrainingContext _context;

        public TrainingRepo(TrainingContext context)
        {
            _context = context;
        }

        public void Add(Training item)
        {
      try
      {
        _context.Training.Add(item);
        _context.SaveChanges();
        //throw new NotImplementedException();
      }
      catch (Exception)
      {
        throw;
      }
    }

        public void Delete(int id)
        {
      try
      {
        var item = _context.Training.Find(id);
        _context.Training.Remove(item);
        _context.SaveChanges();
        //throw new NotImplementedException();
      }
      catch (Exception)
      {
        throw;
      }
    }

        public IEnumerable<Training> GetAll()
        {
      try
      {
        return _context.Training;
        // throw new NotImplementedException();
      }
      catch (Exception)
      {
        throw;
      }
    }

        public Training GetById(int id)
        {
      try
      {
        return _context.Training.Find(id);
        // return _context.Employees.SingleOrDefault(i => i.Eid == id);
        // throw new NotImplementedException();
      }
      catch (Exception)
      {
        throw;
      }
    }

        public void Update(Training item)
        {
      try
      {
        _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        _context.SaveChanges();
        //throw new NotImplementedException();
      }
      catch (Exception)
      {
        throw;
      }
    }

        public void Block(int id)
        {
            //throw new NotImplementedException();
        }
   

    public List<Training> GetTrainingByUid(int id)
    {
      try
      {
        return _context.Training.Where(i => i.Uid == id).ToList();
      }
      catch (Exception)
      {
        throw;
      }
    }
    public List<Training> GetTrainingByMid(int id)
    {
      try
      {
        return _context.Training.Where(i => i.Mid == id).ToList();
      }
      catch (Exception)
      {
        throw;
      }
    }
  }
}
