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
    [Register ("MainProgram")]
    partial class RealTimeHR
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel AthleteMeasuredLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton BackToMainMenuButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel BPMLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView HRHighImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView HRImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel HRZoneLabel { get; set; }

        [Action ("BackToMainMenuButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BackToMainMenuButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (AthleteMeasuredLabel != null) {
                AthleteMeasuredLabel.Dispose ();
                AthleteMeasuredLabel = null;
            }

            if (BackToMainMenuButton != null) {
                BackToMainMenuButton.Dispose ();
                BackToMainMenuButton = null;
            }

            if (BPMLabel != null) {
                BPMLabel.Dispose ();
                BPMLabel = null;
            }

            if (HRHighImage != null) {
                HRHighImage.Dispose ();
                HRHighImage = null;
            }

            if (HRImage != null) {
                HRImage.Dispose ();
                HRImage = null;
            }

            if (HRZoneLabel != null) {
                HRZoneLabel.Dispose ();
                HRZoneLabel = null;
            }
        }
    }
}