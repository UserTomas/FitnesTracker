using System;
using System.Windows;

namespace FitnessTracker.Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly LoginWindow _login = new LoginWindow();

        public MainWindow()
        {
            InitializeComponent();
            _login.LoginEvent+= LoginOnLoginEvent;
            _login.ShowDialog();
        }

        private void LoginOnLoginEvent(object sender, EventArgs e)
        {
            //TODO login to service

            _login.Close();
        }
    }
}
