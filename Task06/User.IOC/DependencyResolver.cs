using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDAO.Interfaces;
using UserDAL;
using UserBLL.Interfaces;
using UserBLL;
using UserFileDAO.Interfaces;
using SaveToFile.DAL;
using AwardDAO.Interfaces;
using AwardDAL;
using AwardBLL.Interfaces;
using AwardBLL;

namespace User.IOC
{
    public static class DependencyResolver
    {
        private static IUserDAO _userDao;
        public static IUserDAO UserDao => _userDao ?? (_userDao = new UserFakeDAO());


        private static IUserLogic _userLogic;
        public static IUserLogic UserLogic => _userLogic ?? (_userLogic = new UserLogic(UserDao, UserFileDAO));


        private static IUserFileDAO _userFileDAO; //для отдельного DAL (сохранение в файл)
        public static IUserFileDAO UserFileDAO => _userFileDAO ?? (_userFileDAO = new SaveToFile.DAL.UserFileDAO());


        private static IAwardDAL _awardDAL;
        public static IAwardDAL AwardDAL => _awardDAL ?? (_awardDAL = new AwardFakeDAL());


        private static IAwardLogic _awardLogic;
        public static IAwardLogic AwardLogic => _awardLogic ?? (_awardLogic = new AwardLogic(AwardDAL));

    }
}
