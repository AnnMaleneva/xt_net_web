using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class User
    {
        private string _name;
        private string _surname;
        private string _patronymic;
        private DateTime _birthday;
        private int _age;

        public User(string _name, string _surname, string _patronymic, DateTime _birthday )
        {
            UserName = _name;
            UserSurname = _surname;
            UserPatronymic = _patronymic;
            UserBirthday = _birthday;

        }
       
        public string UserName
        {
            get => _name;
            set => _name = (!string.IsNullOrEmpty(value) && value.All(char.IsLetter)) ? value :
                throw new ArgumentException("Invalid string. Name consists of letters only.");
        }

        public string UserSurname
        {
            get => _surname;
            set => _surname = (!string.IsNullOrEmpty(value) && value.All(char.IsLetter)) ? value :
                throw new ArgumentException("Invalid string. Surname consists of letters only.");
        }

        public string UserPatronymic
        {
            get => _patronymic;
            set => _patronymic = (!string.IsNullOrEmpty(value) && value.All(char.IsLetter)) ? value :
                throw new ArgumentException("Invalid string. Patronymic consists of letters only.");
        }

        public DateTime UserBirthday { get { return _birthday; } set { _birthday = value; } }

        public int UserAge { get { return (DateTime.Now.Year - UserBirthday.Year); } }

    }
}
