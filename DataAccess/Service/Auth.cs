namespace DataAccess.Service
{
    using System.Linq;
    using Repository;
    using Entity;

    public class Auth
    {
        public UserEntity LoggedUser { get; private set; }

        public void AuthenticateUser(string username, string password)
        {
            UsersRepository usersRepository = new UsersRepository();
            LoggedUser = usersRepository.GetAll(u => u.Username == username && u.Password == password).FirstOrDefault();
        }

        public AdminEntity LoggedAdmin { get; private set; }

        public void AuthenticateAdmin(string username, string password)
        {
            AdminRepository adminRepository = new AdminRepository();
            LoggedAdmin = adminRepository.GetAll(u => u.Username == username && u.Password == password).FirstOrDefault();
        }
    }
}