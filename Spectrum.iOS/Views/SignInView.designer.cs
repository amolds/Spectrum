// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Spectrum.iOS.Views
{
	[Register ("SignInView")]
	partial class SignInView
	{
		[Outlet]
		UIKit.UIButton CreateAccount { get; set; }

		[Outlet]
		UIKit.UITextField Password { get; set; }

		[Outlet]
		UIKit.UIButton SignIn { get; set; }

		[Outlet]
		UIKit.UITextField UserName { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (UserName != null) {
				UserName.Dispose ();
				UserName = null;
			}

			if (Password != null) {
				Password.Dispose ();
				Password = null;
			}

			if (SignIn != null) {
				SignIn.Dispose ();
				SignIn = null;
			}

			if (CreateAccount != null) {
				CreateAccount.Dispose ();
				CreateAccount = null;
			}
		}
	}
}
