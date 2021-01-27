using System;
using MvvmCross.Navigation;
using MvvmCross.Platforms.Ios.Views;
using Spectrum.Core.ViewModels;
using UIKit;

namespace Spectrum.iOS.Views
{
    [MvxFromStoryboard("SignIn")]
    public partial class SignInView : MvxViewController<SignInViewModel>
    {
        public SignInView() : base(nameof(SignInView), null)
        {
        }

        public SignInView(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            var set = this.CreateBindingSet();
            set.Bind(UserName).To(vm => vm.UserName);
            set.Bind(Password).To(vm => vm.Password);
            set.Bind(SignIn).To(vm => vm.SignInCommand);
            set.Bind(SignIn).For(btn => btn.Enabled).To(vm => vm.CanSignIn);
            set.Bind(CreateAccount).To(vm => vm.CreateAccountCommand);
            set.Apply();
        }        

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

