using AuthorizationMicroService.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationMicroService.Services
{
    public class TokenService:ITokenService
    {
        private readonly ITokenRepository _tokenRepository;
        public TokenService(ITokenRepository tokenRepository)
        {
            _tokenRepository = tokenRepository;
        }
        public string GenerateJSONWebToken(string user, IConfiguration _config)
        {
            return _tokenRepository.GenerateJSONWebToken(user, _config);
        }
    }
}
