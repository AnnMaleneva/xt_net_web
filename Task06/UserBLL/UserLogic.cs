using System;
using System.Collections.Generic;
using UserBLL.Interfaces;
using UserDAO.Interfaces;
using UserEntities;
using SaveToFile.DAL;
using UserFileBLL.Interfaces;
using UserFileDAO.Interfaces;

namespace UserBLL
{
    public class UserLogic : IUserLogic, IUserFileLogic
    {
        private readonly IUserDAO _userDao;
        private readonly IUserFileDAO _saveUser;

        public UserLogic(IUserDAO userDao, IUserFileDAO userFileDAO) //в логику передается интерфейс а не конкретная реализация, так получается слабое связывание
        {
            _userDao = userDao;
            _saveUser = userFileDAO;

        }
           
        public User AddUser(User user) //методами в классе userLogic я только вызываю методы из класса UserDAO, ибо там основые действия
        {
            return _userDao.AddUser(user); //на экземпляре класса UserDAO вызываю метод 
        }


        public User GetByID(int id)
        {
            return _userDao.GetByID(id);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userDao.GetAllUsers();
        }

        public void SaveUserInTxtFile(User user)
        {
            _saveUser.SaveUserInTxtFile(user);
        }
    }
}
