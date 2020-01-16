using AwardDAO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserEntities;

namespace AwardDAL
{
    public class AwardFakeDAL : IAwardDAL
    {
        public static readonly Dictionary<int, Award> _awards = new Dictionary<int, Award>();
        public Award AddAward(Award award)
        {
            var lastId = _awards.Keys.Count > 0 ? _awards.Keys.Max() : 0; 
            award.AwardID = lastId + 1; 
            _awards.Add(award.AwardID, award);
            return award;
        }

        public Award GetAwardById(int id)
        {
            _awards.TryGetValue(id, out var award);
            return award;
        }

        public IEnumerable<Award> GetAllAwards()
        {
            return _awards.Values;
        }

        public void AddUserToAward(int userId, int awardId)
        {
            _awards[awardId].AwardUsers.Add(userId);
        }



    }
}
