using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationMicroService.Services
{
    public interface ITokenService
    {
        public string GenerateJSONWebToken(string user, IConfiguration _config);
    }
}
