using System.Collections.Generic;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using MvvmCrossForms.Models;
using MvvmCrossForms.Services;

namespace MvvmCrossForms.ViewModels
{
    public class ContactListViewModel :
        MvxViewModel
    {
        private readonly IDataService _dataService;

        private List<Contact> _contacts;

        public List<Contact> Contacts
        {
            get { return _contacts; }
            set
            {
                _contacts = value;
                this.RaisePropertyChanged(() => this.Contacts);
            }
        }

        public Contact SelectedContact
        {
            get { return null; }
            set
            {
                this.ShowViewModel<ContactViewModel>(value);
                RaisePropertyChanged();
            }
        }

        public ContactListViewModel(IDataService dataService)
        {
            _dataService = dataService;
        }

        public async Task Init()
        {
            this.Contacts = await _dataService.GetContacts();
        }
    }
}
