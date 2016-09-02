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

            var alert = UIAlertController.Create("Alarm", "Wake up sleeping giant!", UIAlertControllerStyle.Alert);

            alert.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Cancel, null));
            
            
        }

        partial void UIButton663_TouchUpInside(UIButton sender)
        {
            
        }
    }
}