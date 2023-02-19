using Foundation;
using System;
using UIKit;

namespace PulseAthlete.Resources.Models.ViewControllers
{
    public partial class MainMenu : UIViewController
    {
        public int Index 
        { 
            get; 
            set; 
        }

        public MainMenu (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
            base.ViewDidLoad();

            UsernameLabel.Text = Account.user[Index].username + " (Coach)";

            AthletesTableView.Source = new TeamTableSource(Team.athlete, this);
		}

        partial void AddButton_TouchUpInside(UIButton sender)
        {
            PerformSegue("AddAthleteSegue", this);
        }

        partial void LogoutButton_TouchUpInside(UIButton sender)
        {
            PerformSegue("LogoutSegue", this);
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

            if (segue.Identifier == "HRcalculationSegue")
            {
                var hrCalc = (HRZoneCalculation)segue.DestinationViewController;

                var tableviewSource = new TeamTableSource(Team.athlete, this);

                string name = tableviewSource.SelectedAthleteName(AthletesTableView);
                int age = tableviewSource.SelectedAthleteAge(AthletesTableView);

                hrCalc.AthleteName = name;
                hrCalc.AthleteAge = age;
            }

            if (segue.Identifier == "RealTimeHRSegue")
            {
                var realTime = (RealTimeHR)segue.DestinationViewController;

                var tableviewSource = new TeamTableSource(Team.athlete, this);

                string name = tableviewSource.SelectedAthleteName(AthletesTableView);

                realTime.Name = name;
            }
        }
    }
}