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
using System.Text.RegularExpressions;

namespace MedicineSearch
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ULogin()
        {
            Objects.User obj = new Objects.User();
            obj.Email = txtEmail.Text.ToString();
            obj.Password = txtPassword.Password.ToString();
            int vcheck = new BLL.User().ULogin(obj);
            if (vcheck > 0)
            {
                ControlPanel Cp = new ControlPanel();
                Cp.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Please enter valid email or password");
            }


        }
        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            Close();
        }


        private void btnLogin1(object sender, RoutedEventArgs e)
        {
            if (txtEmail.Text.Length == 0)
            {
                errormessage.Text = "Enter an email.";
                txtEmail.Focus();
            }
            else if (!Regex.IsMatch(txtEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                errormessage.Text = "Enter a valid email.";
                txtEmail.Select(0, txtEmail.Text.Length);
                txtEmail.Focus();
            }
            else
            {
                ULogin();
            }
        }


    }
}
