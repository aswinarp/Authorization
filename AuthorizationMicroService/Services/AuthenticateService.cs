using AuthorizationMicroService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationMicroService.Services
{
    public class AuthenticateService: IAuthenticateService
    {
        private readonly IAuthenticateRepository _authenticateRepository;
        public AuthenticateService(IAuthenticateRepository authenticateRepository)
        {
            _authenticateRepository = authenticateRepository;
        }
        public bool Verified(string name, string pass)
        {
            return _authenticateRepository.Verified(name, pass);
        }
    }
}
