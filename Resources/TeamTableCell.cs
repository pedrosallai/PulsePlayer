using System;
using System.Threading.Tasks;
using UIKit;

namespace PulseAthlete.Resources.Models.ViewControllers
{
    public partial class TeamTableCell : UITableViewCell
    {
        Random random = new Random();

        public TeamTableCell (IntPtr handle) : base (handle)
        {
        }

        internal async void UpdateCell(Athlete athlete)
        {
            AthleteNameLabelTable.Text = athlete.name;

            if (athlete.restingHR != 0)
            {
                for (int i = 0; i < 300; i++)
                {
                    int beat = random.Next((int)Math.Round(athlete.targetHRmin, 0) + 14, 
                                           (int)Math.Round(athlete.targetHRmax, 0) + 5);
                    BPMLabelTable.Text = beat.ToString();

                    if (beat > athlete.targetHRmax)
                    {
                        BPMLabelTable.TextColor = UIColor.Black;
                        BPMImage.Hidden = true;
                        BPMHighImage.Hidden = false;
                    }
                    if (beat <= athlete.targetHRmax)
                    {
                        BPMLabelTable.TextColor = UIColor.Red;
                        BPMImage.Hidden = false;
                        BPMHighImage.Hidden = true;
                    }
                    await Task.Delay(1000);
                }
            }
            else
            {
                BPMLabelTable.Text = "";
            }
        }
    }
}