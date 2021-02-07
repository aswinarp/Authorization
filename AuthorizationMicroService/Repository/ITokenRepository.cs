using Microsoft.Extensions.Configuration;

namespace AuthorizationMicroService.Repository
{
    public interface ITokenRepository
    {
        public string GenerateJSONWebToken(string user ,IConfiguration _config);
    }
}
