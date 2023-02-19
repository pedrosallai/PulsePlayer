using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace PulseAthlete.Resources.Models.ViewControllers
{
    public class TeamTableSource : UITableViewSource
    {
        private List<Athlete> team;
        private MainMenu controller;

        public TeamTableSource(List<Athlete> team, MainMenu controller)
        {
            this.team = team;
            this.controller = controller;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            if (Team.athlete[indexPath.Row].restingHR != 0)
            {
                controller.PerformSegue("RealTimeHRSegue", controller);
            }
            else
            {
                controller.PerformSegue("HRcalculationSegue", controller);
            }
        }

        public override UITableViewRowAction[] EditActionsForRow(UITableView tableView, NSIndexPath indexPath)
        {
            var action = UITableViewRowAction.Create(UITableViewRowActionStyle.Default, "Delete", (arg1, arg2) =>
            {
                Team.athlete.RemoveAt(indexPath.Row);

                var cell = (TeamTableCell)tableView.CellAt(arg2);
                tableView.DeleteRows(new NSIndexPath[] { indexPath }, withRowAnimation: UITableViewRowAnimation.Fade);
            });

            return new UITableViewRowAction[] { action };
        }

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
            var cell = (TeamTableCell) tableView.DequeueReusableCell("TableCell", indexPath);

            var athlete = team[indexPath.Row];

            cell.UpdateCell(athlete);

            return cell;
		}

		public override nint RowsInSection(UITableView tableview, nint section)
        {
            return team.Count;
        }

        public string SelectedAthleteName(UITableView tableView)
        {
            var indexPath = tableView.IndexPathForSelectedRow;

            string name = team[indexPath.Row].name;

            return name;
        }

        public int SelectedAthleteAge(UITableView tableView)
        {
            var indexPath = tableView.IndexPathForSelectedRow;

            int age = team[indexPath.Row].age;

            return age;
        }

        public int SelectedAthleteRestingHR(UITableView tableView)
        {
            var indexPath = tableView.IndexPathForSelectedRow;

            int restingHR = team[indexPath.Row].restingHR;
            
            return restingHR;
        }

        public double SelectedAthleteTargetHRmin(UITableView tableView)
        {
            var indexPath = tableView.IndexPathForSelectedRow;

            double targetHRmin = team[indexPath.Row].targetHRmin;

            return targetHRmin;
        }

        public double SelectedAthleteTargetHRmax(UITableView tableView)
        {
            var indexPath = tableView.IndexPathForSelectedRow;

            double targetHRmax = team[indexPath.Row].targetHRmax;

            return targetHRmax;
        }
    }
}