using PropertyChanged;

namespace MvvmCrossForms.Models
{
    [ImplementPropertyChanged]
    public class Contact
    {
        public string Name { get; set; }
        public string Number { get; set; }
    }
}