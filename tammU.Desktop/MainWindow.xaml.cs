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
using System.Windows.Navigation;
using System.Windows.Shapes;
using tammU.Application.Interfaces.Services;
using tammU.Desktop.Pages;
using tammU.Domain.Commons;
using tammU.Domain.Models;

namespace tammU.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public readonly IUserService userService;
        public MainWindow(IUserService userService)
        {
            InitializeComponent();
            this.userService = userService;
        }
        public MainWindow() { }

        private void Main_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameBoxUI.Text;
            string password = PasswordBoxUI.Password;
            BaseResponse<User> user = null;

            if (String.IsNullOrEmpty(username)) MessageBox.Show("Enter username");
            else if (password == "") MessageBox.Show("Enter password");
            else if (true)
            {
                if (true)
                {
                    Main.Content = new Main();
                }
                else MessageBox.Show("Incorrect Password!");
            }
            else MessageBox.Show(user.ErrorMessage);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Main.Content = new Register(userService);
        }
    }
}
