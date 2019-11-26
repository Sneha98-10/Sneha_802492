using Microsoft.EntityFrameworkCore;
using MOD.AuthenticateService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.AuthenticateService.Context
{
  public class LoginContext:DbContext
  {
    public LoginContext(DbContextOptions<LoginContext> options) : base(options)
    {

    }
    //protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
    //{
    //    optionBuilder.UseSqlServer(@"Server = DESKTOP-NCNTOC7\KRITHIKA;Database=MODdb;Trusted_Connection=True");
    //}
    public DbSet<User> User { get; set; }
    public DbSet<Mentor> Mentor { get; set; }
   



  }
}

