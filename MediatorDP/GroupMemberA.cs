using System;

namespace MediatorDP
{
    //These are the classes that communicate with each other via the mediator.
    public class GroupMemberA : GroupMember
    {
        public GroupMemberA(IFacebookGroup facebookGroup) : base(facebookGroup)
        {
        }

        public void Send(string msg)
        {
            Console.WriteLine("Member A send message:" + msg);
            this._facebookGroup.SendNotification(this, msg);
        }

        public void Receive(string msg)
        {
            Console.WriteLine("Member A receive message:" + msg);
        }
    }
}
