using Oracle.ManagedDataAccess.Client;
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

namespace AddressBook
{
    /// <summary>
    /// LoginPage.xaml 的交互逻辑
    /// </summary>
    public partial class LoginPage : Page
    {
        private string ID, password;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            ID = IDTextBox.Text;
            password = PWTextBox.Password;
            App.connection = new OracleConnection();
            //App.connection.ConnectionString = $"Data Source=orcl;User Id={ID};Password={password}";
            App.connection.ConnectionString = $"Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = orcl)));User Id={ID};Password={password}";
            try
            {
                App.connection.Open();
            }
            catch(Exception exception)
            {
                LogStaTB.Text = exception.ToString();
                return;
            }
            if ($"{App.connection.State}" == "Open")
            {
                LogStaTB.Text = "登录成功！";
                MainWindow.Current.setUserTextBlock(ID);
                MainWindow.Current.setListBox(true);
                App.command = App.connection.CreateCommand();
            }
            else
            {
                LogStaTB.Text = "登录失败！";
                MainWindow.Current.setListBox(false);
            }
            
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            string str = "";
            try
            {
                App.connection.Close();
                str = App.connection.State.ToString();
            }
            catch(Exception)
            {

            }
            if (str == "Closed")
            {
                LogStaTB.Text = "退出成功！";
                MainWindow.Current.setUserTextBlock("未登录");
                MainWindow.Current.setListBox(false);
            }
        }
    }
}
