
namespace MediatorDP
{
    // Members
    //This is a class that defines a single, protected field that holds a reference to a mediator.
    public abstract class GroupMember
    {
        protected IFacebookGroup _facebookGroup;

        public GroupMember(IFacebookGroup facebookGroup)
        {
            _facebookGroup = facebookGroup;
        }
    }
}
