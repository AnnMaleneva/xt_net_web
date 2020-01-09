using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDAO.Interfaces;
using UserEntities;
using UserFileDAO.Interfaces;

namespace SaveToFile.DAL
{
    public class UserFileDAO : IUserFileDAO
    {
        public void SaveUserInTxtFile(User user)
        {
            string path = @"C:\Users\EvilLittlePony\Desktop\EPAM Traning\Решение заданий\Users.txt";

            using (StreamWriter str = new StreamWriter(path, true))
            {
                str.WriteLine(JsonConvert.SerializeObject(user));                 
            }
        }
    }
}
