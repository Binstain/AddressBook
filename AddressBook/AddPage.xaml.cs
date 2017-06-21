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
    /// AddPage.xaml 的交互逻辑
    /// </summary>
    public partial class AddPage : Page
    {
        public AddPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(nameTextBox.Text.Trim() == "" || sexTextBox.Text.Trim() == "" || byTextBox.Text.Trim() == "" ||
                contTextBox.Text.Trim() == "" || addTextBox.Text.Trim() == "")
            {
                LogTextBlock.Text = "所有选项都不能为空";
                return;
            }

            int year;
            try
            {
                year = int.Parse(byTextBox.Text);
            }
            catch(Exception)
            {
                LogTextBlock.Text = "出生年份输入错误。";
                return;
            }

            if (sexTextBox.Text != "男" && sexTextBox.Text != "女")
            {
                LogTextBlock.Text = "性别必须为“男”或者“女”";
                return;
            }

            string count = "-2";
            App.command.CommandText = "select max(no) from student";
            try
            {
                App.reader = App.command.ExecuteReader();
                App.reader.Read();
                count = App.reader.GetString(0);

            }
            catch(Exception exception)
            {
                LogTextBlock.Text = exception.ToString();
                return;
            }
            //LogTextBlock.Text = count;

            int no = int.Parse(count) + 1;
            
            App.command.CommandText = "insert into student(no, name, sex, birthyear, contact, address) "
                                        + $"values('{no.ToString()}','{nameTextBox.Text}','{sexTextBox.Text}','{year}','{contTextBox.Text}','{addTextBox.Text}')";
            try
            {
                App.command.ExecuteNonQuery();
            }
            catch(Exception exception)
            {
                LogTextBlock.Text = "添加失败，请检查输入。";
                return;
            }

            LogTextBlock.Text = "添加成功。";

        }
    }
}
