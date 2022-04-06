namespace APIAuthentication.Repositories
{
    public class UserRepository
    {
        public User Get(string username, string password )
        {
                return new User(){Id =1, UserName = "Marcelo", Password = "123", Role = "manager"};
        }
    }
}