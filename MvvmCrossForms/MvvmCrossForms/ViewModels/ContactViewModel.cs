using MvvmCross.Core.ViewModels;
using MvvmCrossForms.Models;

namespace MvvmCrossForms.ViewModels
{
    public class ContactViewModel :
        MvxViewModel
    {
        public Contact Contact { get; set; }

        public void Init(Contact contact)
        {
            this.Contact = contact;
        }
    }
}