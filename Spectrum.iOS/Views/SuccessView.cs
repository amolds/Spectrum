using System;
using MvvmCross.Platforms.Ios.Views;
using Spectrum.Core.ViewModels;
using UIKit;

namespace Spectrum.iOS.Views
{
    [MvxFromStoryboard]
    public partial class SuccessView : MvxViewController<SuccessViewModel>
    {
        public SuccessView() : base(nameof(SuccessView), null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

