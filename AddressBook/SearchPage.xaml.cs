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
    /// SearchPage.xaml 的交互逻辑
    /// </summary>
    public partial class SearchPage : Page
    {
        public SearchPage()
        {
            InitializeComponent();
        }

        private void AllSearBut_Click(object sender, RoutedEventArgs e)
        {
            //MainWindow.Current.setFrame("changePage.xaml");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.ss = new Student();

            if (nameTextBox.Text.Trim() != "")
            {
                App.ss.Name = nameTextBox.Text;
            }
            else
                App.ss.Name = null;

            if (sexTextBox.Text.Trim() != "")
            {
                App.ss.Sex = sexTextBox.Text;
            }
            else
                App.ss.Sex = null;

            if (byTextBox.Text.Trim() != "")
            {
                App.ss.Birthyear = int.Parse(byTextBox.Text);
            }
            else
                App.ss.Birthyear = null;

            if (contTextBox.Text.Trim() != "")
            {
                App.ss.Contact = contTextBox.Text;
            }
            else
                App.ss.Contact = null;

            if (addTextBox.Text.Trim() != "")
            {
                App.ss.Address = addTextBox.Text;
            }
            else
                App.ss.Address = null;

            MainWindow.Current.setFrame("changePage.xaml");
        }
    }
}
