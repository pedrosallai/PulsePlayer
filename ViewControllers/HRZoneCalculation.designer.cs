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
    [Register ("THRZCalculation")]
    partial class HRZoneCalculation
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIActivityIndicatorView ActivityHRcalculation { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton BackToMainMenuButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CalculateButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel CalculatingLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel RestHRErrorLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField RestingHRField { get; set; }

        [Action ("BackToMainMenuButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BackToMainMenuButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("CalculateButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void CalculateButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (ActivityHRcalculation != null) {
                ActivityHRcalculation.Dispose ();
                ActivityHRcalculation = null;
            }

            if (BackToMainMenuButton != null) {
                BackToMainMenuButton.Dispose ();
                BackToMainMenuButton = null;
            }

            if (CalculateButton != null) {
                CalculateButton.Dispose ();
                CalculateButton = null;
            }

            if (CalculatingLabel != null) {
                CalculatingLabel.Dispose ();
                CalculatingLabel = null;
            }

            if (RestHRErrorLabel != null) {
                RestHRErrorLabel.Dispose ();
                RestHRErrorLabel = null;
            }

            if (RestingHRField != null) {
                RestingHRField.Dispose ();
                RestingHRField = null;
            }
        }
    }
}