using Foundation;
using UIKit;

namespace PulseAthlete.Resources.Models.ViewControllers
{
    internal class AthletesTableViewDelegate : UITableViewDelegate
    {
        private MainMenu _controller;

        public AthletesTableViewDelegate(MainMenu controller)
        {
            this._controller = controller;
        }
        
		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
            if (Team.team[indexPath.Row].restingHR != 0)
            {
                _controller.PerformSegue("MainbpmprogramSegue", _controller);
            }
            else
            {
                _controller.PerformSegue("HRcalculationSegue", _controller);
            }
		}

		public override UITableViewRowAction[] EditActionsForRow(UITableView tableView, NSIndexPath indexPath)
        {
            var action = UITableViewRowAction.Create(UITableViewRowActionStyle.Default, "Delete", (arg1, arg2) =>
            {
                //Team.athletes.RemoveAt(indexPath.Row);
                Team.team.RemoveAt(indexPath.Row);

                var cell = (TeamTableCell) tableView.CellAt(arg2);
                tableView.DeleteRows(new NSIndexPath[] { indexPath }, withRowAnimation: UITableViewRowAnimation.Fade);
            });

            return new UITableViewRowAction[] { action };
        }
    }
}