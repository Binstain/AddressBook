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
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow Current;

        public MainWindow()
        {
            InitializeComponent();
            frame.Navigate(new Uri("LoginPage.xaml", UriKind.Relative));
            Current = this;
            MyListBox.IsEnabled = false;
            MyListBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFABADB3"));
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(Login.IsSelected)
            {
                frame.Navigate(new Uri("LoginPage.xaml", UriKind.Relative));
            }
            else if(Search.IsSelected)
            {
                frame.Navigate(new Uri("SearchPage.xaml", UriKind.Relative));
            }
            else if(Add.IsSelected)
            {
                frame.Navigate(new Uri("AddPage.xaml", UriKind.Relative));
            }
            else if(Drop.IsSelected)
            {
                frame.Navigate(new Uri("DropPage.xaml", UriKind.Relative));
            }
            MyListBox.SelectedIndex = -1;
        }

        public void setListBox(bool b)
        {
            if(b)
            {
                MyListBox.IsEnabled = true;
                MyListBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF000000"));
                userTB.Foreground =  new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF000000"));
            }
            else
            {
                MyListBox.IsEnabled = false;
                MyListBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFABADB3"));
                userTB.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFABADB3"));
            }
        }

        public void setUserTextBlock(string str)
        {
            userTB.Text = str;
        }

        public void setFrame(string uri)
        {
            frame.Navigate(new Uri(uri, UriKind.Relative));
        }

        public void setFrame(string uri, int para)
        {
            frame.Navigate(new Uri(uri, UriKind.Relative), para);
        }
    }
}
