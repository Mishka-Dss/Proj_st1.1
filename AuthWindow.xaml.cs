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
using WpfAppDautov.Logic;
using WpfAppKolodchenkoVitaly.Logic;

namespace WpfAppKolodchenkoVitaly
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        private IAuthService _authService;

        public AuthWindow(IAuthService authService)
        {
            _authService = authService;
        }

        public AuthWindow()
        {
            InitializeComponent();
            _authService = new AuthService();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Close()
        {
            throw new NotImplementedException();
        }

        private void BtnOpen_Click(object sender, RoutedEventArgs e)
        {
            string login = tbxlogin.Text;
            string pass = tbxPass.Text;

            if (_authService.CheckData(login, pass))
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
            }
            else
            {
                MessageBox.Show("Ошибка, проверьте правильность введённых данных в полях");
            }
        }
    }
}
