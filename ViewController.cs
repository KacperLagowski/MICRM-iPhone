using System;
using UIKit;
using SIML.CRMData;

namespace MICRM_iPhone
{
    public partial class ViewController : UIViewController
    {
        public string test;
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            test = "hello";

            
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void UIButton100_TouchUpInside(UIButton sender)
        {
            throw new NotImplementedException();
        }
    }
}
