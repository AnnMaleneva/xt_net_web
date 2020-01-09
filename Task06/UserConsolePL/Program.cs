using System;
using User.IOC;
using UserEntities;


namespace UserConsolePL
{
    class Program
    {
        static void Main(string[] args)
        {
            var logic = DependencyResolver.UserLogic;
            var a = logic.AddUser(new UserEntities.User() { Name = "Ann", DateOfBirth = new DateTime(1992,02,04)});
            logic.SaveUserInTxtFile(a);
            var b = logic.AddUser(new UserEntities.User() { Name = "Ivan", DateOfBirth = new DateTime(1988,06,12)});
            logic.SaveUserInTxtFile(b);

            var award = DependencyResolver.AwardLogic;
            award.AddAward(new Award() { AwardID = 1, TitleAward = "Award" });
            award.AddAward(new Award() { AwardID = 2, TitleAward = "Award2" });



            foreach (var item in logic.GetAllUsers())
            {
                Console.WriteLine(item);
            }

            foreach (var item in award.GetAllAwards())
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
