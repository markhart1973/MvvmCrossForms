using System.Collections.Generic;
using System.Threading.Tasks;
using MvvmCrossForms.Models;

namespace MvvmCrossForms.Services
{
    public interface IDataService
    {
        Task<List<Contact>> GetContacts();
    }
}