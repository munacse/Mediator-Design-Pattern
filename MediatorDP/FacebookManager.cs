
namespace MediatorDP
{
    //Mediator Manager
    //This is a class that implement the communication operations of the Mediator interface.
    public class FacebookManager : IFacebookGroup
    {
        public GroupMemberA groupMemberA { get; set; }

        public GroupMemberB groupMemberB { get; set; }

        public void SendNotification(GroupMember caller, string msg)
        {
            if (caller == groupMemberA)
                groupMemberB.Receive(msg);
            else
                groupMemberA.Receive(msg);
        }
    }
}
