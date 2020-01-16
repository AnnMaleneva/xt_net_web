using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserEntities
{
    public class Award
    {
        public int AwardID { get; set; }

        public string TitleAward { get; set; }

        public IList<int> AwardUsers { get; } = new List<int>();

        public override string ToString()
        {
            return $"{AwardID} {TitleAward} {AwardUsers}";
        }
    }
}
