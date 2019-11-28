using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class Employee : User
    {        
        private string _workPosition;
        private DateTime _workExperience;
        private DateTime _employmentDate;

        public string WorkPosition
        {
            get => _workPosition;
            set => _workPosition = (!string.IsNullOrEmpty(value) && value.All(char.IsLetter)) ? value :
                throw new ArgumentException("Invalid string. 'Work position' consists of letters only.");
        }

        public DateTime EmploymentDate { get; set; }
        public int WorkExperience => (DateTime.Now.Year - EmploymentDate.Year);


        public Employee(string _name, string _surname, string _patronymic, DateTime _birthday, string _workPosition, DateTime _employmentDate)
            : base (_name, _surname, _patronymic, _birthday)
        {
            WorkPosition = _workPosition;
            EmploymentDate = _employmentDate;
        }
    }
}
