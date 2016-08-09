using System.Collections.Generic;
using System.Threading.Tasks;
using MvvmCrossForms.Models;

namespace MvvmCrossForms.Services
{
    public class DataService :
        IDataService
    {
        public async Task<List<Contact>> GetContacts()
        {
            await Task.Delay(3000);
            return new List<Contact>
            {
                new Contact {Name="Peter", Number="01772409099" },
                new Contact {Name="james", Number="01772789069" }
            };
        }
    }
}
