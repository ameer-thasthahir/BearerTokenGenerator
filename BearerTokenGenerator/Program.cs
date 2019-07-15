using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace BearerTokenGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {       
          var _subject = new ClaimsIdentity(new Claim[]
                        {
                            new Claim("User", "e8b3d754-786e-4269-a668-7ed7ae580630"),

                            new Claim("Details", "Valuable"),                            
                        });          

            var tokenHandler = new JwtSecurityTokenHandler();

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = _subject,

                Issuer = "OAuthIssuer",

                Expires = DateTime.Now.AddHours(12),

                IssuedAt = DateTime.Now
            };

            var securityToken = tokenHandler.CreateToken(tokenDescriptor);

            var jwtToken = tokenHandler.WriteToken(securityToken);

            Console.WriteLine(jwtToken);


            Console.ReadLine();
        }
    }
}
