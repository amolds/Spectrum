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
	[Register ("CreateAccountView")]
	partial class CreateAccountView
	{
		[Outlet]
		UIKit.UIButton CreateAccount { get; set; }

		[Outlet]
		UIKit.UITextField FirstName { get; set; }

		[Outlet]
		UIKit.UITextField LastName { get; set; }

		[Outlet]
		UIKit.UITextField Password { get; set; }

		[Outlet]
		UIKit.UITextField Phone { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (FirstName != null) {
				FirstName.Dispose ();
				FirstName = null;
			}

			if (LastName != null) {
				LastName.Dispose ();
				LastName = null;
			}

			if (Phone != null) {
				Phone.Dispose ();
				Phone = null;
			}

			if (Password != null) {
				Password.Dispose ();
				Password = null;
			}

			if (CreateAccount != null) {
				CreateAccount.Dispose ();
				CreateAccount = null;
			}
		}
	}
}
