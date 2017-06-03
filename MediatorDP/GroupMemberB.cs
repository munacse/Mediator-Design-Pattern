using System;

namespace MediatorDP
{
    //These are the classes that communicate with each other via the mediator.
    public class GroupMemberB : GroupMember
    {
        public GroupMemberB(IFacebookGroup facebookGroup) : base(facebookGroup)
        {
        }

        public void Send(string msg)
        {
            Console.WriteLine("Member B send message:" + msg);
            this._facebookGroup.SendNotification(this, msg);
        }

        public void Receive(string msg)
        {
            Console.WriteLine("Member B receive message:" + msg);
        }
    }
}
