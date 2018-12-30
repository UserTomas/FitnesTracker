using System;
using System.Windows;
using System.Windows.Media;

namespace FitnessTracker.Client
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public event EventHandler LoginEvent;

        public LoginWindow()
        {
            InitializeComponent();
            BtnLogin.Click += BtnLoginOnClick;
            BtnCreateAccount.Click += BtnCreateAccountOnClick; 
        }

        private void BtnCreateAccountOnClick(object sender, RoutedEventArgs e)
        {
            //TODO later maybe 
        }

        private void BtnLoginOnClick(object sender, RoutedEventArgs e)
        {
            if (!CheckBoxes())
                return;
            TextResult.Foreground = Brushes.CadetBlue;
            TextResult.Text = "Connecting";
            LoginEvent?.Invoke(this, EventArgs.Empty);
        }

        private bool CheckBoxes()
        {
            if (string.IsNullOrWhiteSpace(TextUser.Text))
            {
                TextResult.Text = "User name is missing";
                TextUser.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(TextPassword.Text))
            {
                TextResult.Text = "Password is missing";
                TextPassword.Focus();
                return false;
            }
            return true;
        }
    }
}
