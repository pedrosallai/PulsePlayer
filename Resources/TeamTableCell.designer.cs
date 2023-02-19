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
    [Register ("TableViewCell")]
    partial class TeamTableCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel AthleteNameLabelTable { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView BPMHighImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView BPMImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel BPMLabelTable { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (AthleteNameLabelTable != null) {
                AthleteNameLabelTable.Dispose ();
                AthleteNameLabelTable = null;
            }

            if (BPMHighImage != null) {
                BPMHighImage.Dispose ();
                BPMHighImage = null;
            }

            if (BPMImage != null) {
                BPMImage.Dispose ();
                BPMImage = null;
            }

            if (BPMLabelTable != null) {
                BPMLabelTable.Dispose ();
                BPMLabelTable = null;
            }
        }
    }
}