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
using System.Data.SqlClient;


namespace Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            String name = lastName+" "+firstName;
            //Do validation first
            if (firstName.Text == ""|| lastName.Text ==""||birthday.Text=="")
                MessageBox.Show("Please enter your information!");
            //calculate age
            
            int year = 0;
            DateTime oDate = Convert.ToDateTime(birthday.Text);
            year = DateTime.Now.Year - oDate.Year;
            if (DateTime.Now.DayOfYear < year)
                year -= 1;
            String age = year.ToString();

            //connect database
            SqlConnection conn = new SqlConnection("Data Source=(local); Initial Catalog=company; Integrated Security=True");
            conn.Open();

            //insert user data
            string str = "insert into Employee(firstName, lastName, birthday, age) values('" + firstName.Text + "','" + lastName.Text + "','" + birthday.Text + "','" + age + "')";

            SqlCommand insert = new SqlCommand(str, conn);

            insert.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            //go to hello page
            hello newWindow = new hello(name, age);
            //newWindow.Title = "Thank you!";
            //newWindow.Content = "Thank you, " + name + ", " + age + " years old";
            newWindow.Show();
            this.Close();
            InitializeComponent();
        }

    }
}
