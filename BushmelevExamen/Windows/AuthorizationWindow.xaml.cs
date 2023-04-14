using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace BushmelevExamen.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        int countAttemps = 0;
        int secondsLock = 10;
        DispatcherTimer timer = new DispatcherTimer();
        public AuthorizationWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Classes.ConnectDB.tradeEntities = new DataBaseModel.BumbleBeeLionEntities();
            if (!Classes.ConnectDB.tradeEntities.Database.Exists())
            {
                MessageBox.Show("База не подключена!");
                App.Current.Shutdown();
            }
        }
        private void LogOn(object sender, RoutedEventArgs e)
        {
            countAttemps++;
            if (!string.IsNullOrEmpty(txtBoxLogin.Text) && !string.IsNullOrEmpty(pswdBoxPassword.Password))
            {
                var user = Classes.ConnectDB.tradeEntities.User.FirstOrDefault(u => u.UserPassword == pswdBoxPassword.Password && u.UserLogin == txtBoxLogin.Text);
                if (user != null)
                {
                    MainMenuWindow mainMenuWindow = new MainMenuWindow();
                    mainMenuWindow.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("Такого пользователя нет!");
            }
            else
            {
                MessageBox.Show("Некоторые поля пустые!");
            }
            if (countAttemps > 3)
            {
                timer.Tick += new EventHandler(timerTick);
                timer.Interval = TimeSpan.FromSeconds(1);
                timer.Start();
                this.IsEnabled = false;
                txtBlockLockTimer.Visibility = Visibility.Visible;
            }
        }

        private void timerTick(object sender, EventArgs e)
        {
            txtBlockLockTimer.Text = "Ожидайте " + secondsLock + " сек.";
            secondsLock--;
            if (secondsLock == 0)
            {
                txtBlockLockTimer.Visibility = Visibility.Hidden;
                this.IsEnabled = true;
                timer.Stop();
            }
        }

        private void LogOnGuest(object sender, RoutedEventArgs e)
        {
            MainMenuWindow mainMenuWindow = new MainMenuWindow();
            mainMenuWindow.Show();
            this.Close();
        }
    }
}
