using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserEntities;

namespace AwardDAO.Interfaces
{
    public interface IAwardDAL
    {
        Award AddAward(Award award);


        Award GetAwardById(int id);

        IEnumerable<Award> GetAllAwards();


        void AddUserToAward(int userId, int awardId);


    }
}
