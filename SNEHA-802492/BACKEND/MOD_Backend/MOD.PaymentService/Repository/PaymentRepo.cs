using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.PaymentService.Context;
using MOD.PaymentService.Models;

namespace MOD.PaymentService.Repository
{
    public class PaymentRepo :PaymentRepository
    {
        private readonly PaymentContext _context;
        public PaymentRepo(PaymentContext context)
        {
            _context = context;
        }

        public void Add(Payment item)
        {
      try
      {
        _context.Payment.Add(item);
        _context.SaveChanges();
      }
      catch (Exception)
      {
        throw;
      }
    }

        public List<Payment> GetAll()
        {
      try
      {
        return _context.Payment.ToList();
      }
      catch (Exception)
      {
        throw;
      }
    }

        public Payment GetById(int id)
        {
      try
      {
        return _context.Payment.Find(id);
      }
      catch (Exception)
      {
        throw;
      }
    }

    }
}
