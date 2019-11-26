using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.TechnologyService.Context;
using MOD.TechnologyService.Models;

namespace MOD.TechnologyService.Repository
{
    public class SkillsRepo :SkillsRepository
    {
        private readonly SkillsContext _context;
        public SkillsRepo(SkillsContext context)
        {
            _context = context;
        }

        public void Add(Skills item)
        {
      try
      {
        _context.Skills.Add(item);
        _context.SaveChanges();
      }
      catch (Exception)
      {
        throw;
      }
    }

        public List<Skills> GetAll()
        {
      try
      {
        return _context.Skills.ToList();
      }
      catch (Exception)
      {
        throw;
      }
    }

        public Skills GetById(int id)
        {
      try
      {
        return _context.Skills.Find(id);
      }
      catch (Exception)
      {
        throw;
      }
    }

        public void Update(Skills item)
        {
      try
      {
        _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        _context.SaveChanges();
      }

      catch (Exception)
      {
        throw;
      }
    }
    

}
}
