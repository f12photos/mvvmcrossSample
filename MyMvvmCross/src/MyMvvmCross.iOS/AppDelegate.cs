using Foundation;
using MvvmCross.Platforms.Ios.Core;
using MyMvvmCross.Core;

namespace MyMvvmCross.iOS
{
    [Register(nameof(AppDelegate))]
    public class AppDelegate : MvxApplicationDelegate<Setup, App>
    {
    }
}
