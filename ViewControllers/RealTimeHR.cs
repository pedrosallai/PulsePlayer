using System;
using System.Threading.Tasks;
using UIKit;

//Target HR = ((HRMAX – HRREST) × %Intensity) + HRREST
//HeartRateMAX = 211 – 0.64 × age

namespace PulseAthlete.Resources.Models.ViewControllers
{
    public partial class RealTimeHR : UIViewController
    {
        public string Name
        {
            get;
            set;
        }

        public RealTimeHR(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            AthleteMeasuredLabel.Text = Name;

            int index = Team.athlete.FindIndex(r => r.name == Name);

            HRZoneLabel.Text = Math.Round(Team.athlete[index].targetHRmin, 0).ToString() + "-" + Math.Round(Team.athlete[index].targetHRmax, 0).ToString();
            //double targetHRmax = Team.athlete[index].targetHRmax;

            BPM(Team.athlete[index].targetHRmax);
        }

        public async void BPM(double targetHRmax)
        {
            bool snooze = false;

            for (int i = 0; i < 300; i++)
            {
                int beat = ((int)Math.Round(targetHRmax, 0) - 10) + i;
                BPMLabel.Text = beat.ToString();

                await Task.Delay(1000);

                if (beat > targetHRmax)
                {
                    BPMLabel.TextColor = UIColor.Black;
                    HRImage.Hidden = true;
                    HRHighImage.Hidden = false;

                    if (snooze == false)
                    {
                        var alert = UIAlertController.Create
                          (Name + "'s heart rate is too high", "Substitution is recommended.", UIAlertControllerStyle.Alert);
                        alert.AddAction(UIAlertAction.Create
                          ("OK", UIAlertActionStyle.Cancel, null));
                        alert.AddAction(UIAlertAction.Create
                          ("Snooze", UIAlertActionStyle.Default, (Action) => { snooze = true; }));
                        PresentViewController(alert, true, null);
                    }
                }
                else
                {
                    BPMLabel.TextColor = UIColor.Red;
                    HRImage.Hidden = false;
                    HRHighImage.Hidden = true;
                }
            }
        }

        partial void BackToMainMenuButton_TouchUpInside(UIButton sender)
        {
            PerformSegue("BackToMainMenuSegue", this);
        }
    }
}