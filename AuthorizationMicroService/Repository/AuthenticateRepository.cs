using System.Collections.Generic;
using System.Linq;
using AuthorizationMicroService.Models;

namespace AuthorizationMicroService.Repository
{
    public class AuthenticateRepository:IAuthenticateRepository
    {
        public bool Verified(string name, string pass)
        {
            IDictionary<string, string> userDetails = UserDetails.GetDetails();
            for (int i = 0; i < 3; i++)
            {
                if (name == userDetails.ElementAt(i).Key && pass == userDetails.ElementAt(i).Value)
                    return true;
            }
            return false;
        }
    }
}
