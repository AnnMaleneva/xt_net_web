using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UserDAO.Interfaces;
using UserEntities;
using UserFileDAO.Interfaces;

namespace UserDAL
{
    public class UserFakeDAO : IUserDAO, IUserFileDAO //data access object 
    {
        private static readonly Dictionary<int, User> _users = new Dictionary<int, User>();
        public User AddUser(User user)
        {
            var lastId = _users.Keys.Count > 0 ? _users.Keys.Max() : 0; //получаю значение последнего ID, если занят увелич.на 1
            user.ID = lastId + 1; //если написать ++ не работает
            _users.Add(user.ID, user);
            return user;
        }

        public User GetByID(int id)
        {
            _users.TryGetValue(id, out var user);
            return user;
        }

        public IEnumerable<User> GetAllUsers() //перечисление юзеров из dictionary по value
        {
            return _users.Values;
        }

        public void SaveUserInTxtFile(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}
