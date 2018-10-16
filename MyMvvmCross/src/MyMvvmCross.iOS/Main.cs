using UIKit;

namespace MyMvvmCross.iOS
{
    public static class Application
    {
        private static void Main(string[] args)
        {
            UIApplication.Main(args, null, nameof(AppDelegate));
        }
    }
}
