using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserEntities;

namespace UserFileDAO.Interfaces
{
    public interface IUserFileDAO
    {
        void SaveUserInTxtFile(User user);
      
    }
}
