using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationMicroService.Services
{
    public interface IAuthenticateService
    {
        public bool Verified(string name, string pass);
    }
}
