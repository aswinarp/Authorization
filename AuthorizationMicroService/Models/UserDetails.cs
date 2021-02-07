using System.Collections.Generic;

namespace AuthorizationMicroService.Models
{
    public static class UserDetails
    {
        public static IDictionary<string, string> GetDetails()
        {
            IDictionary<string, string> userDetails = new Dictionary<string, string>() // Add 3 pharmacist details below as username and password respectively
            {
                {"Aswin", "password"},
                {"Rudransh", "password"},
                {"Gargi", "password"},
            };
            return userDetails;
        }
    }
}
