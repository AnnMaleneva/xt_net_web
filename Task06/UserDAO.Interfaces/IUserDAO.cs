using System.Collections.Generic;
using UserEntities;

namespace UserDAO.Interfaces
{
    public interface IUserDAO
    {
        User AddUser(User user);

        User GetByID(int id);

        IEnumerable<User> GetAllUsers();


    }
}
