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
using System.Data;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Oracle.ManagedDataAccess.Client;

namespace AddressBook
{
    /// <summary>
    /// changePage.xaml 的交互逻辑
    /// </summary>
    public partial class changePage : Page
    {
        ObservableCollection<Student> students;
        List<int> chanegdList;
        List<Student> deletedList;

        public changePage()
        {
            InitializeComponent();
            AllDataGrid.ItemsSource = getStudents();
            chanegdList = new List<int>();
            deletedList = new List<Student>();            
        }

        ObservableCollection<Student> getStudents()
        {
            students = new ObservableCollection<Student>();
            bool hasPre = false;
            App.command.CommandText = "select * from student";
            if (App.ss.Name != null || App.ss.Sex != null || App.ss.Birthyear != null ||
                App.ss.Contact != null || App.ss.Address != null)
            {
                App.command.CommandText += " where ";
                if(App.ss.Name != null)
                {
                    App.command.CommandText += $"name='{App.ss.Name}'";
                    hasPre = true;
                }
                if(App.ss.Sex != null)
                {
                    if (hasPre)
                        App.command.CommandText += $" and ";
                    App.command.CommandText += $"sex='{App.ss.Sex}'";
                    hasPre = true;
                }
                if(App.ss.Birthyear != null)
                {
                    if (hasPre)
                        App.command.CommandText += $" and ";
                    App.command.CommandText += $"'{App.ss.Birthyear}'";
                    hasPre = true;
                }
                if(App.ss.Contact != null)
                {
                    if (hasPre)
                        App.command.CommandText += $" and ";
                    App.command.CommandText += $"'{App.ss.Contact}'";
                    hasPre = true;
                }
                if(App.ss.Address != null)
                {
                    if (hasPre)
                        App.command.CommandText += $" and ";
                    App.command.CommandText += $"'{App.ss.Address}'";
                    hasPre = true;
                }
            }
           
            try
            {
                App.reader = App.command.ExecuteReader();
                while (App.reader.Read())
                {
                    students.Add(new Student(App.reader.GetString(0).Trim(), App.reader.GetString(1).Trim(), 
                                    App.reader.GetString(2).Trim(), App.reader.GetInt32(3), App.reader.GetString(4).Trim(), App.reader.GetString(5).Trim()));
                }
            }
            catch(Exception exception)
            {
                ErrorTextBlock.Text = exception.ToString();
            }
            return students;
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            AllDataGrid.IsReadOnly = !AllDataGrid.IsReadOnly;
            if((string)editButton.Content == "编辑")
            {
                editButton.Content = "浏览";
            }
            else
            {
                editButton.Content = "编辑";
            }
        }

        private void AllDataGrid_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            Student student = e.Row.Item as Student;
            if(student.Name.Trim() == "" || student.Sex.Trim() == "" || student.Contact.Trim() == "" ||
                student.Address.Trim() == "")
            {
                ErrorTextBlock.Text = "所有选项都不能为空。";
                return;
            }
            if ((student.Sex != "男" && student.Sex != "女"))
            {
                ErrorTextBlock.Text = "性别必须为“男”或者“女”。";
                return;
            }
            chanegdList.Add(e.Row.GetIndex());

            //ErrorTextBlock.Text += "点了一下 ";
            //Student student = new Student();
            //student = e.Row.Item as Student;
            //App.command.CommandText = $"update student set no='{student.No}'";
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            if(chanegdList.Count() == 0 && deletedList.Count() == 0)
            {
                return;
            }

            try
            {
                for (int i = 0; i < chanegdList.Count; i++)
                {
                    updataStudent(chanegdList[i]);
                }
            }
            catch(Exception)
            {
                ErrorTextBlock.Text = "保存失败，请检出输入并重新查询。";
            }
            chanegdList.Clear();

            try
            {
                foreach (Student s in deletedList)
                {
                    App.command.CommandText = $"delete from student where no='{s.No}'";
                    App.command.ExecuteNonQuery();
                }
            }
            catch(Exception exception)
            {
                //ErrorTextBlock.Text = exception.ToString();
                ErrorTextBlock.Text = "删除失败，请重新查询。";
                return;               
            }
            ErrorTextBlock.Text = "保存成功。";
            deletedList.Clear();
        }

        private void updataStudent(int index)
        {
            Student student = students[index];
            App.command.CommandText = $"update student set no='{student.No}',name='{student.Name}',"
                                        + $"sex='{student.Sex}',birthyear='{student.Birthyear}',contact='{student.Contact}',"
                                        + $"address='{student.Address}' "
                                        + $"where no='{student.No}'";
            try
            {            
                App.command.ExecuteNonQuery();
            }
            catch(Exception exception)
            {
                throw exception;
            }
            //ErrorTextBlock.Text = chanegdList.Count.ToString() + "\n";
            //ErrorTextBlock.Text += App.command.CommandText;
        }

        private void dropButton_Click(object sender, RoutedEventArgs e)
        {
            foreach(Student s in deletedList)
            {
                students.Remove(s);
            }

        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)(sender as CheckBox).IsChecked)
            {
                deletedList.Add(AllDataGrid.SelectedItem as Student);
            }
            else
            {
                deletedList.Remove(AllDataGrid.SelectedItem as Student);
            }                   
        }
    }
}
