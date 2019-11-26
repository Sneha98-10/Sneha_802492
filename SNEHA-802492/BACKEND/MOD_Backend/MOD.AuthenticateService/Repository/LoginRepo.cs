using MOD.AuthenticateService.Context;
using MOD.AuthenticateService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.AuthenticateService.Repository
{
  public class LoginRepo : LoginRepository
  {

    private readonly LoginContext _context;
    public LoginRepo(LoginContext context)
    {
      _context = context;
    }
    public Mentor Mentorlogin(string Email, string Mpassword)
    {
      try
      {
        return _context.Mentor.SingleOrDefault(data => data.Mmail == Email && data.Mpassword == Mpassword);
        //if (obj != null)
        //  return true;
        //else
        //  return false;
      }
      catch (Exception)
      {
        throw;
      }
    }
    public User Userlogin(string Email, string Upassword)
    {
      try
      {
        return _context.User.SingleOrDefault(data => data.Umail == Email && data.Upassword == Upassword);
        //if (obj != null)
        //  return true;
        //else
        //  return false;
      }
      catch (Exception)
      {
        throw;
      }
    }
  }
}
