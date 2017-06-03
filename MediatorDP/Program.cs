using System;

namespace MediatorDP
{
    class Program
    {
        static void Main(string[] args)
        {
            FacebookManager facebookManager = new FacebookManager();
            facebookManager.groupMemberA = new GroupMemberA(facebookManager);
            facebookManager.groupMemberB = new GroupMemberB(facebookManager);
            GroupMemberA memberA = new GroupMemberA(facebookManager);
            facebookManager.SendNotification(memberA, "Hello And Hi");

            GroupMemberB memberB = new GroupMemberB(facebookManager);
            facebookManager.SendNotification(memberB, "Good And Bye");

            Console.ReadKey();
        }
    }
}
