using System;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;
using Spectrum.Core.ViewModels;
using UIKit;

namespace Spectrum.iOS.Views
{
    // NOTE: in the storyboard I have one view and I set the background color to Orange.
    // The class and storyboard id have the same value "ExampleView"

    // Storyboard name in the Views folder...
    [MvxFromStoryboard("ExampleView")]
    // I have tried with and without this line...
    //[MvxRootPresentation(WrapInNavigationController = true)]
    public partial class ExampleView : MvxViewController<ExampleViewModel>
    {
        public ExampleView(IntPtr handle) : base(handle)
        {
            // This line is indeed executed... yet the screen is white.
            var x = 1;
        }

        public ExampleView() : base(nameof(ExampleView), null)
        {
            var x = 2;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            this.MyButton.TouchUpInside += MyButton_TouchUpInside;
        }

        private void MyButton_TouchUpInside(object sender, EventArgs e)
        {
            var x = 3;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

