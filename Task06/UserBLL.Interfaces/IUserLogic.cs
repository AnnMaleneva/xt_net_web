using System.Collections.Generic;
using UserEntities;

namespace UserBLL.Interfaces
{
    public interface IUserLogic
    {
        User AddUser(User user);

        User GetByID(int id);

        IEnumerable<User> GetAllUsers();

        void SaveUserInTxtFile(User user);

    }
}
