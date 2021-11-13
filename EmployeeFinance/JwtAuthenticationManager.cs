using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace EmployeeFinance
{
    public class JwtAuthenticationManager : IJwtAuthenticationManager
    {
        private readonly IDictionary<string, string> users = new Dictionary<string, string> {
            { "ranjan","password1"},
            {"arup","password2" }
        };
        private readonly string key;
        private IDictionary<string, string> UsersRefreshToken = new Dictionary<string, string>();

        public JwtAuthenticationManager(string key)
        {
            this.key = key;
        }
        private string GenerateToken()
        {
            var randomNumber = new byte[32];
            using (var rendomNumberGenerator = RandomNumberGenerator.Create())
            {
                rendomNumberGenerator.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }
        private AuthenticationResponse Authenticate(string userName, Claim[] claims)
        {
            var tokenKey = Encoding.ASCII.GetBytes(key);
            var expires = DateTime.UtcNow.AddHours(1);
            var token = new JwtSecurityToken(claims: claims, expires: expires,
                signingCredentials: new SigningCredentials(
                    new SymmetricSecurityKey(tokenKey),
                    SecurityAlgorithms.HmacSha256Signature));

            var refreshToken = GenerateToken();
            if (UsersRefreshToken.ContainsKey(userName))
            {
                UsersRefreshToken[userName] = refreshToken;
            }
            else
            {
                UsersRefreshToken.Add(userName, refreshToken);
            }
            return new AuthenticationResponse { Token = new JwtSecurityTokenHandler().WriteToken(token), RefreshToken = refreshToken, Expires = expires };
        }
        public AuthenticationResponse RefreshToken(RefreshTokenInfo refreshTokenInfo)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken validatedToken;
            var princpal = tokenHandler.ValidateToken(refreshTokenInfo.Token,
                new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key)),
                    ValidateIssuer = false,
                    ValidateAudience = false
                }, out validatedToken);
            var token = validatedToken as JwtSecurityToken;
            if (token == null || !token.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
            {
                throw new SecurityTokenException("Invalid token passed!");
            }
            var userName = princpal.Identity.Name;
            if (refreshTokenInfo.RefreshToken != UsersRefreshToken[userName])
            {
                throw new SecurityTokenException("Invalid token passed!");
            }
            return Authenticate(userName, princpal.Claims.ToArray());
        }

        public AuthenticationResponse Authenticate(string userName, string password)
        {
            if (!users.Any(u => u.Key == userName && u.Value == password))
            {
                return null;
            }
            var tokenHnadler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.ASCII.GetBytes(key);
            var expires = DateTime.UtcNow.AddHours(1);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, userName),
                    new Claim(ClaimTypes.Role,"Admin")
                }),
                Expires = expires,
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(tokenKey),
                    SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHnadler.CreateToken(tokenDescriptor);
            var refreshToken = GenerateToken();
            if (UsersRefreshToken.ContainsKey(userName))
            {
                UsersRefreshToken[userName] = refreshToken;
            }
            else
            {
                UsersRefreshToken.Add(userName, refreshToken);
            }

            return new AuthenticationResponse { Token = tokenHnadler.WriteToken(token), RefreshToken = refreshToken, Expires = expires };
        }

    }
}
