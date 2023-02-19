using Foundation;
using System;
using UIKit;

namespace PulseAthlete.Resources.Models.ViewControllers
{
    public partial class Register : UIViewController
    {
        public Register (IntPtr handle) : base (handle)
        {
        }

        partial void BackToLoginButton_TouchUpInside(UIButton sender)
        {
            PerformSegue("BackToLoginSegue", this);
        }

		partial void RegisterButton_TouchUpInside(UIButton sender)
        {
            string username = RegUsernameField.Text;
            string password = RegPasswordField.Text;

            if (String.IsNullOrWhiteSpace(username) && String.IsNullOrWhiteSpace(password))
            {
                InvalidUnameLabel.Text = "please enter a username";
                InvalidPassLabel.Text = "please enter a password";
            }

            if (String.IsNullOrWhiteSpace(username))
            {
                if (!String.IsNullOrWhiteSpace(password))
                {
                    InvalidUnameLabel.Text = "please enter a username";
                    InvalidPassLabel.Text = "";
                }
            }

            if (String.IsNullOrWhiteSpace(password))
            {
                if (!String.IsNullOrWhiteSpace(username))
                {
                    InvalidUnameLabel.Text = "";
                    InvalidPassLabel.Text = "please enter a password";
                }
            }

            if (!String.IsNullOrWhiteSpace(username) && !String.IsNullOrWhiteSpace(password))
            {
                bool usernameTaken = false;
                bool usernamePasswordMatch = false;

                for (int i = 0; i < Account.user.Count; i++)
                {
                    if (Account.user[i].username == username)
                    {
                        usernameTaken = true;

                        if (Account.user[i].password == password)
                        {
                            usernamePasswordMatch = true;
                        }
                    }
                }

                if (usernameTaken == true)
                {
                    InvalidPassLabel.Text = "";
                    InvalidUnameLabel.Text = "username is already taken";
                }

                if (usernamePasswordMatch == true)
                {
                    InvalidUnameLabel.Text = "";

                    var alert = UIAlertController.Create("Account already exists", "", UIAlertControllerStyle.Alert);
                    alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Cancel, (Action) => { PerformSegue("BackToLoginSegue", this); }));
                    PresentViewController(alert, true, null);
                }

                if (usernameTaken == false && usernamePasswordMatch == false)
                {
                    /*if (Account.user.Count == 0)
                    {
                        Account.user.Add(new User { ID = 0, username = username, password = password });
                    }
                    else{
                        int ID = Account.user.Count;
                        Account.user.Add(new User { ID = ID, username = username, password = password });
                    }*/

                    Account.user.Add(new User { username = username, password = password });
                    PerformSegue("UserRegisteredSegue", this);
                }
            }
        }
    }
}