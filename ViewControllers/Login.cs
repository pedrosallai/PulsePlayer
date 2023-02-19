using System;
using Foundation;
using UIKit;

namespace PulseAthlete.Resources.Models.ViewControllers
{
    public partial class Login : UIViewController
    {
        protected Login(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
            base.PrepareForSegue(segue, sender);

            if (segue.Identifier == "MainmenuSegue")
            {
                var main = (MainMenu)segue.DestinationViewController;

                int index = Account.user.FindIndex(r => r.username == UsernameField.Text);
                main.Index = index;
            }
		}

        partial void GoToRegisterButton_TouchUpInside(UIButton sender)
        {
            PerformSegue("GoToRegisterSegue", this);
        }

        partial void LoginButton_TouchUpInside(UIButton sender)
        {
            bool usernamePasswordMatch = false;

            string username = UsernameField.Text;
            string password = PasswordField.Text;

            if (String.IsNullOrWhiteSpace(username) && String.IsNullOrWhiteSpace(password))
            {
                NoMatchLabel.Text = "";
                InvalidUsernameLabel.Text = "please enter a username";
                InvalidPasswordLabel.Text = "please enter a password";
            }

            if (String.IsNullOrWhiteSpace(username))
            {
                if (!String.IsNullOrWhiteSpace(password))
                {
                    NoMatchLabel.Text = "";
                    InvalidUsernameLabel.Text = "please enter a username";
                    InvalidPasswordLabel.Text = "";
                }
            }

            if (String.IsNullOrWhiteSpace(password))
            {
                if (!String.IsNullOrWhiteSpace(username))
                {
                    NoMatchLabel.Text = "";
                    InvalidUsernameLabel.Text = "";
                    InvalidPasswordLabel.Text = "please enter a password";
                }
            }

            if (!String.IsNullOrWhiteSpace(username) && !String.IsNullOrWhiteSpace(password))
            {
                for (int i = 0; i < Account.user.Count; i++)
                {
                    if (Account.user[i].username.Equals(username))
                    {
                        if (Account.user[i].password.Equals(password))
                        {
                            usernamePasswordMatch = true;
                        }
                    }
                }

                if (usernamePasswordMatch == true)
                {
                    PerformSegue("MainmenuSegue", this);
                }
                else
                {
                    InvalidUsernameLabel.Text = "";
                    InvalidPasswordLabel.Text = "";
                    NoMatchLabel.Text = "user credentials don't exist. have you registered yet?";
                }
            }
        }
    }
}
