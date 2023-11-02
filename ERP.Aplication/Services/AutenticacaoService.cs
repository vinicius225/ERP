using ERP.Aplication.Interfaces;
using ERP.Domain.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

namespace ERP.Aplication.Services
{
    public class AutenticacaoService : IAutenticacaoService
    {
        private readonly IConfiguration _config;

        private readonly string _secretKey;
        private readonly string _issuer;
        private readonly string _audience;
        private readonly int _hours;
        public AutenticacaoService(IConfiguration config)
        {
            _config = config;
            _secretKey = _config["AutenticacaoJWT:SecretKey"];
            _issuer = _config["AutenticacaoJWT:Issuer"];
            _audience = _config["AutenticacaoJWT:Audience"];
            _hours = int.Parse(_config["AutenticacaoJWT:TimeExpiration"]);
        }

        public string GerarToken(Usuario usuario)
        {
            var authSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_secretKey));

            var token = new JwtSecurityToken(
                issuer: _issuer,
                audience: _audience,
                expires: DateTime.Now.AddHours(_hours),
                //claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
            );
            return new  JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
