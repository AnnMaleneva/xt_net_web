using AwardBLL.Interfaces;
using AwardDAO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserEntities;

namespace AwardBLL
{
    public class AwardLogic : IAwardLogic
    {
        private readonly IAwardDAL _awardDao;

        public AwardLogic(IAwardDAL awardDao)
        {
            _awardDao = awardDao;
        }

        public Award AddAward(Award award)
        {
            return _awardDao.AddAward(award);
        }

        public void AddUserToAward(int userId, int awardId)
        {
            _awardDao.AddUserToAward(userId, awardId);
        }

        public IEnumerable<Award> GetAllAwards()
        {
            return _awardDao.GetAllAwards();
        }

        public Award GetAwardById(int id)
        {
            return _awardDao.GetAwardById(id);
        }
    }
}
