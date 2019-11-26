using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MOD.AuthenticateService.Models;
using MOD.AuthenticateService.Repository;

namespace MOD.AuthenticateService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
    private readonly LoginRepository _repository;
    public LoginController(LoginRepository repository)
    {
      _repository = repository;
    }

    [HttpGet]
    [Route("Validate/{mailid}/{pwd}")]
    public Atoken Get(string mailid, string pwd)
    {
      if (_repository.Userlogin(mailid, pwd)!=null)
      {
        User response = _repository.Userlogin(mailid, pwd);
        return new Atoken() { message = "User", token = response.Uid.ToString() };
      }
      else if (_repository.Mentorlogin(mailid, pwd)!=null)
      {
        Mentor response = _repository.Mentorlogin(mailid, pwd);
        return new Atoken() { message = "Mentor", token = response.Mid.ToString() };
      }
      else if (mailid == "123@gmail.com" && pwd == "admin123")
      {
        return new Atoken() { message = "Admin", token = GetToken() };
      }
      else
      {
        return new Atoken() { message = "Invalid User", token = "" };
      }
    }
    public string GetToken()
    {
      var _config = new ConfigurationBuilder()
                  .SetBasePath(Directory.GetCurrentDirectory())
                  .AddJsonFile("appsettings.json").Build();
      var issuer = _config["Jwt:Issuer"];
      var audience = _config["Jwt:Audience"];
      var expiry = DateTime.Now.AddMinutes(120);
      var securityKey = new SymmetricSecurityKey
  (Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
      var credentials = new SigningCredentials
  (securityKey, SecurityAlgorithms.HmacSha256);

      var token = new JwtSecurityToken(issuer: issuer,
  audience: audience,
  expires: DateTime.Now.AddMinutes(120),
  signingCredentials: credentials);

      var tokenHandler = new JwtSecurityTokenHandler();
      var stringToken = tokenHandler.WriteToken(token);
      return stringToken;
     
    }
  }
}
