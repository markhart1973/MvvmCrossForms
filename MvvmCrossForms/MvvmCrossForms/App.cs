using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;
using MvvmCrossForms.ViewModels;

namespace MvvmCrossForms
{
    public class App :
        MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            this.RegisterAppStart<ContactListViewModel>();
        }
    }
}