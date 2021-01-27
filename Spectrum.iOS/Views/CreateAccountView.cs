using System;
using MvvmCross.Platforms.Ios.Views;
using Spectrum.Core.ViewModels;
using UIKit;

namespace Spectrum.iOS.Views
{
    [MvxFromStoryboard("CreateAccount")]
    public partial class CreateAccountView : MvxViewController<CreateAccountViewModel>
    {
        public CreateAccountView() : base(nameof(CreateAccountView), null)
        {
        }

        public CreateAccountView(IntPtr handle) : base(handle)
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

