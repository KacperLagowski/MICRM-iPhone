using Foundation;
using System;
using UIKit;

namespace MICRM_iPhone
{
    public partial class Menu : UIViewController
    {
        public Menu (IntPtr handle) : base (handle)
        {
        }

        partial void UIButton441_TouchUpInside(UIButton sender)
        {

            var alertController = UIAlertController.Create("Your Count", "Added 1 PC", UIAlertControllerStyle.Alert);
        }

        partial void UIButton663_TouchUpInside(UIButton sender)
        {
            
        }
    }
}