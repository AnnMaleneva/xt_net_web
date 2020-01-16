using System;
using System.Collections.Generic;

namespace UserEntities
{
    public class User
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Age => DateTime.Now.Year - DateOfBirth.Year;

        public IList<int> UserAwards { get; } = new List<int>();

        public override string ToString()
        {
            return $"{ID} {Name} {Age}";
        }


    }
}
