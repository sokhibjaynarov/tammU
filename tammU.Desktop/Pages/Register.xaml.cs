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
using tammU.Application.ViewModels;
using tammU.Domain.Commons;
using tammU.Domain.Models;
using tammU.Infrastructure.Services.Services;

namespace tammU.Desktop.Pages
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Page
    {
        public readonly IUserService userService;
        public Register(IUserService userService)
        {
            InitializeComponent();
            this.userService = userService;
        }

        private async void Button_Click_Submit(object sender, RoutedEventArgs e)
        {
            string password1 = PasswordBox1.Password;
            string password2 = PasswordBox2.Password;
            string firstName = FnameBox.Text;
            string lastName = LnameBox.Text;
            string email = EmailBox.Text;
            string gender = GenderBox.Text;
            string username = UsernameBox.Text;
            string birth = BirthdayBox.Text;

            if (String.IsNullOrEmpty(username)) MessageBox.Show("Enter username");
            else if (String.IsNullOrEmpty(password1)) MessageBox.Show("Enter password");
            else if (String.IsNullOrEmpty(password2)) MessageBox.Show("Enter password");
            else if (String.IsNullOrEmpty(firstName)) MessageBox.Show("Enter first name");
            else if (String.IsNullOrEmpty(lastName)) MessageBox.Show("Enter last name");
            else if (String.IsNullOrEmpty(gender)) MessageBox.Show("Enter gender");
            else if (String.IsNullOrEmpty(birth)) MessageBox.Show("Enter birthday");
            else if (String.IsNullOrEmpty(email)) MessageBox.Show("Enter email");
            else if (password2 != password1) MessageBox.Show("Do not input different password!");
            else
            {
                UserViewModel userDto = new UserViewModel()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    Password = password1,
                    Username = username
                };

                BaseResponse<User> user = await userService.CreateAsync(userDto);

                if(user.Data == null) MessageBox.Show(user.ErrorMessage);
                else
                {
                    Registration.Content = new Main();
                }
            }

        }

        private void Button_Click_Reset(object sender, RoutedEventArgs e)
        {
            PasswordBox1.Password = "";
            PasswordBox2.Password = "";
            FnameBox.Text = "";
            LnameBox.Text = "";
            EmailBox.Text = "";
            GenderBox.Text = "";
            UsernameBox.Text = "";
            BirthdayBox.Text = "";
        }

        private void Button_Click_Login(object sender, RoutedEventArgs e)
        {
            Registration.Content = new Login(userService);
        }

        private void Registration_Navigated(object sender, NavigationEventArgs e)
        {
            
        }
    }
}
