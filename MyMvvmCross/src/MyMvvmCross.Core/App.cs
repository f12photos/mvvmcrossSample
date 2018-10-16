using MvvmCross.IoC;
using MvvmCross.ViewModels;
using MyMvvmCross.Core.ViewModels.Main;

namespace MyMvvmCross.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<MainViewModel>();
        }
    }
}
