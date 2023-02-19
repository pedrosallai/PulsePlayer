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
    [Register ("AddSportsman")]
    partial class AddAthlete
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField AddAgeField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton AddAthleteButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField AddNameField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton BackToMainMenuButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel InvalidAgeLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel InvalidNameLabel { get; set; }

        [Action ("AddAthleteButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void AddAthleteButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("BackToMainMenuButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BackToMainMenuButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (AddAgeField != null) {
                AddAgeField.Dispose ();
                AddAgeField = null;
            }

            if (AddAthleteButton != null) {
                AddAthleteButton.Dispose ();
                AddAthleteButton = null;
            }

            if (AddNameField != null) {
                AddNameField.Dispose ();
                AddNameField = null;
            }

            if (BackToMainMenuButton != null) {
                BackToMainMenuButton.Dispose ();
                BackToMainMenuButton = null;
            }

            if (InvalidAgeLabel != null) {
                InvalidAgeLabel.Dispose ();
                InvalidAgeLabel = null;
            }

            if (InvalidNameLabel != null) {
                InvalidNameLabel.Dispose ();
                InvalidNameLabel = null;
            }
        }
    }
}