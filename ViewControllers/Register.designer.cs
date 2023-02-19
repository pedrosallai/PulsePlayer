// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace PulseAthlete.Resources.Models.ViewControllers
{
    [Register ("Register")]
    partial class Register
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton BackToLoginButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel InvalidPassLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel InvalidUnameLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton RegisterButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField RegPasswordField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField RegUsernameField { get; set; }

        [Action ("BackToLoginButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BackToLoginButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("RegisterButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void RegisterButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (BackToLoginButton != null) {
                BackToLoginButton.Dispose ();
                BackToLoginButton = null;
            }

            if (InvalidPassLabel != null) {
                InvalidPassLabel.Dispose ();
                InvalidPassLabel = null;
            }

            if (InvalidUnameLabel != null) {
                InvalidUnameLabel.Dispose ();
                InvalidUnameLabel = null;
            }

            if (RegisterButton != null) {
                RegisterButton.Dispose ();
                RegisterButton = null;
            }

            if (RegPasswordField != null) {
                RegPasswordField.Dispose ();
                RegPasswordField = null;
            }

            if (RegUsernameField != null) {
                RegUsernameField.Dispose ();
                RegUsernameField = null;
            }
        }
    }
}