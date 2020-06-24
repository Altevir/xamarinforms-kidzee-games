using UIKit;
using Xamarin.Forms;
using XFKidzeeZone.Interfaces;
using XFKidzeeZone.iOS.Interfaces;

[assembly: Dependency(typeof(StatusBarStyle))]
namespace XFKidzeeZone.iOS.Interfaces
{
    public class StatusBarStyle : IStatusBarStyle
    {
        public void ChangeTextColor()
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                var currentUIViewController = GetCurrentViewController();
                UIApplication.SharedApplication.SetStatusBarStyle(UIStatusBarStyle.LightContent, false);
                currentUIViewController.SetNeedsStatusBarAppearanceUpdate();
            });
        }

        UIViewController GetCurrentViewController()
        {
            var window = UIApplication.SharedApplication.KeyWindow;
            var vc = window.RootViewController;
            while (vc.PresentedViewController != null)
                vc = vc.PresentedViewController;
            return vc;
        }
    }
}