using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MOD.UserService.Context;
using MOD.UserService.Models;

namespace MOD.UserService.Repository
{
    public class UserRepo : UserRepository

    {
        public readonly UserContext _context;

        public UserRepo(UserContext context)
        {
            _context = context;
        }

        public void Add(User item)
        { try
      {
        _context.User.Add(item);
        _context.SaveChanges();
        //throw new NotImplementedException();
      }
      catch(Exception)
      {
        throw;
      }
        }

        public void Delete(int id)
        { try
      {
        var item = _context.User.Find(id);
        _context.User.Remove(item);
        _context.SaveChanges();
        //throw new NotImplementedException();
      }
      catch(Exception)
      {
        throw;
      }
        }

        public List<User> GetAll()
    {
      try
      {
        return _context.User.ToList();
        // throw new NotImplementedException();
      }
      catch(Exception)
      {
        throw;
      }
        }

        public User GetById(int id)
    {
      try
      {
        return _context.User.Find(id);
        // return _context.Employees.SingleOrDefault(i => i.Eid == id);
        // throw new NotImplementedException();
      }
      catch(Exception)
      {
        throw;
      }
        }

        public void Update(User item)
        {
      try
      {
        _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        _context.SaveChanges();
        //throw new NotImplementedException();
      }
      catch(Exception)
      {
        throw;
      }
        }
        public List<Mentor> SearchMentor(string Mentorskills)
        {
      try
      {
        //return _context.Mentors.Find(MentorSkills);

        return _context.Mentor.Where(i => i.Mskills == Mentorskills).ToList();
      }
      catch(Exception)
      {
        throw;
      }

        }


        public void Block(int id)
        {
      try
      {
        var item = _context.User.Find(id);
        if (item.Uactive == true)
        {
          item.Uactive = !(item.Uactive);
        }
        _context.Entry(item).State = EntityState.Modified;
        _context.SaveChanges();
        //throw new NotImplementedException();
      }
      catch(Exception)
      { throw;
      }
        }
    public void UnBlock(int id)
    {
      try
      {
        var item = _context.User.Find(id);
        if (item.Uactive == false)
        {
          item.Uactive = !(item.Uactive);
        }
        _context.Entry(item).State = EntityState.Modified;
        _context.SaveChanges();
        //throw new NotImplementedException();
      }
      catch(Exception)
      {
        throw;
      }
    }

  }
}
