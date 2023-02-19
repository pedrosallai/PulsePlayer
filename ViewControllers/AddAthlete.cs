using Foundation;
using System;
using UIKit;

namespace PulseAthlete.Resources.Models.ViewControllers
{
    public partial class AddAthlete : UIViewController
    {
        public AddAthlete (IntPtr handle) : base (handle)
        {
        }

        partial void BackToMainMenuButton_TouchUpInside(UIButton sender)
        {
            PerformSegue("BackToMainMenuSegue", this);
        }

        partial void AddAthleteButton_TouchUpInside(UIButton sender)
        {
            string name = AddNameField.Text;
            int age = 0;

            if (String.IsNullOrWhiteSpace(name) && String.IsNullOrWhiteSpace(AddAgeField.Text))
            {
                InvalidNameLabel.Text = "please choose a name";
                InvalidAgeLabel.Text = "please enter the athlete's age";
            }

            if (String.IsNullOrWhiteSpace(name))
            {
                if (!String.IsNullOrWhiteSpace(AddAgeField.Text))
                {
                    try
                    {
                        age = int.Parse(AddAgeField.Text);
                    } catch (FormatException) {
                        InvalidAgeLabel.Text = "age must be a number";
                    }
                    
                    InvalidNameLabel.Text = "please choose a name";
                    InvalidAgeLabel.Text = "";
                }
            }

            if (String.IsNullOrWhiteSpace(AddAgeField.Text))
            {
                if (!String.IsNullOrWhiteSpace(name))
                {
                    InvalidNameLabel.Text = "";
                    InvalidAgeLabel.Text = "please enter the athlete's age";
                }
            }

            if (!String.IsNullOrWhiteSpace(name) && !String.IsNullOrWhiteSpace(AddAgeField.Text))
            {
                try
                {
                    age = int.Parse(AddAgeField.Text);
                    //Team.athlete.Add(new Athlete { name = name, age = age , userID = Index});
                    Team.athlete.Add(new Athlete { name = name, age = age });
                    PerformSegue("AthleteAddedSegue", this);
                }
                catch (FormatException)
                {
                    InvalidAgeLabel.Text = "age must be a number";
                }
            }
        }
	}
}