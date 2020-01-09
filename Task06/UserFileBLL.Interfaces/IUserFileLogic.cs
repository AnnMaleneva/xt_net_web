using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserEntities;

namespace UserFileBLL.Interfaces
{
    public interface IUserFileLogic
    {
        void SaveUserInTxtFile(User user);
    }
}
