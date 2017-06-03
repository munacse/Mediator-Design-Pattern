
namespace MediatorDP
{
    //IMediator
    //This is an interface that defines operations which can be called by member objects for communication.
    public interface IFacebookGroup 
    {
        void SendNotification(GroupMember groupMember, string message);
    }
}
