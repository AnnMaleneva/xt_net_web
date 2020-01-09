using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserEntities;

namespace AwardBLL.Interfaces
{
    public interface IAwardLogic
    {
        Award AddAward(Award award);
        
        Award GetAwardById(int id);

        IEnumerable<Award> GetAllAwards();
        
        void AddUserToAward(int userId, int awardId);
    }
}
