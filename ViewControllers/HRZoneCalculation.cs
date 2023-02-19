using Foundation;
using System;
using System.Threading.Tasks;
using UIKit;

//Target HR = ((HRMAX – HRREST) × %Intensity) + HRREST
//HeartRateMAX = 211 – 0.64 × age

namespace PulseAthlete.Resources.Models.ViewControllers
{
    public partial class HRZoneCalculation : UIViewController
    {
        public string AthleteName
        {
            get;
            set;
        }
        
        public int AthleteAge
        {
            get;
            set;
        }
        
        public HRZoneCalculation (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
            base.ViewDidLoad();

            ActivityHRcalculation.Hidden = true;
		}

        partial void BackToMainMenuButton_TouchUpInside(UIButton sender)
        {
            PerformSegue("BackToMainMenuSegue", this);
        }

        partial void CalculateButton_TouchUpInside(UIButton sender)
        {
            int restingHR = 0;

            int index = Team.athlete.FindIndex(r => r.name == AthleteName);
            if (Team.athlete[index].restingHR == 0)
            {
                if (String.IsNullOrWhiteSpace(RestingHRField.Text))
                {
                    RestHRErrorLabel.Text = "please enter the resting HR";
                }
                if (!String.IsNullOrWhiteSpace(RestingHRField.Text))
                {
                    try
                    {
                        restingHR = int.Parse(RestingHRField.Text);

                        float HRmax = (float)(211 - (0.64 * AthleteAge));
                        double targetHRmin = ((HRmax - restingHR) * 0.70) + restingHR;
                        double targetHRmax = ((HRmax - restingHR) * 0.85) + restingHR;

                        Team.athlete[index].restingHR = restingHR;
                        Team.athlete[index].targetHRmin = targetHRmin;
                        Team.athlete[index].targetHRmax = targetHRmax;

                        CalculatingLabel.Text = "Calculating optimal HR zone...";
                        Calculate();
                    }
                    catch (FormatException)
                    {
                        RestHRErrorLabel.Text = "resting HR must be a number";
                    }
                }
            }
            else
            {
                float HRmax = (float)(211 - (0.64 * AthleteAge));
                double targetHRmin = ((HRmax - Team.athlete[index].restingHR) * 0.70) + Team.athlete[index].restingHR;
                double targetHRmax = ((HRmax - Team.athlete[index].restingHR) * 0.85) + Team.athlete[index].restingHR;

                Team.athlete[index].targetHRmin = targetHRmin;
                Team.athlete[index].targetHRmax = targetHRmax;

                CalculatingLabel.Text = "Calculating optimal HR zone...";
                Calculate();
            }
        }

		public async void Calculate()
        {
            ActivityHRcalculation.Hidden = false;
            
            ActivityHRcalculation.StartAnimating();
            await Task.Delay(4000);
            ActivityHRcalculation.StopAnimating();

            PerformSegue("RealTimeHRSegue", this);
        }

		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
			base.PrepareForSegue(segue, sender);

            if (segue.Identifier == "RealTimeHRSegue")
            {
                var main = (RealTimeHR)segue.DestinationViewController;

                main.Name = AthleteName;
            }
		}
	}
}


        /*public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

            UIView.Animate(30, 0, UIViewAnimationOptions.CurveLinear, () =>
            {
                ProgressHRcalculation.SetProgress(1.0f, true);
            }, () =>
            {
                
            }
                );
        }*/