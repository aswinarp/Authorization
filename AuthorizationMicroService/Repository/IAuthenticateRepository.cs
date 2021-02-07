namespace AuthorizationMicroService.Repository
{
    public interface IAuthenticateRepository
    {
        public bool Verified(string name, string pass);
    }
}
