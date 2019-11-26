using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MOD.UserService.Context;
using MOD.UserService.Models;

namespace MOD.UserService.Repository
{
    public class MentorRepo : MentorRepository
    {
        public readonly UserContext _context;

        public MentorRepo(UserContext context)
        {
            _context = context;
        }

        public void Add(Mentor item)
        {
      try
      {
        _context.Mentor.Add(item);
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
        var item = _context.Mentor.Find(id);
        _context.Mentor.Remove(item);
        _context.SaveChanges();
        //throw new NotImplementedException();
      }
      catch (Exception)
      {
        throw;
      }
    }

        public List<Mentor> GetAll()
        {
      try
      {
        return _context.Mentor.ToList();
        // throw new NotImplementedException();
      }
      catch (Exception)
      {
        throw;
      }
    }

        public Mentor GetById(int id)
        {
      try
      {
        return _context.Mentor.Find(id);
        // return _context.Employees.SingleOrDefault(i => i.Eid == id);
        // throw new NotImplementedException();
      }
      catch (Exception)
      {
        throw;
      }
    }

        public void Update(Mentor item)
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
      try
      {
        var item = _context.Mentor.Find(id);
        if (item.Mactive == true)
        {
          item.Mactive = !(item.Mactive);
        }
        item.Mactive = !(item.Mactive);
        _context.Entry(item).State = EntityState.Modified;
        _context.SaveChanges();
        //throw new NotImplementedException();
      }
      catch (Exception)
      {
        throw;
      }
    }
    public void UnBlock(int id)
    {
      try
      {
        var item = _context.Mentor.Find(id);
        if (item.Mactive == false)
        {
          item.Mactive = !(item.Mactive);
        }
        item.Mactive = !(item.Mactive);
        _context.Entry(item).State = EntityState.Modified;
        _context.SaveChanges();
        //throw new NotImplementedException();
      }
      catch (Exception)
      {
        throw;
      }
    }
  }
}
