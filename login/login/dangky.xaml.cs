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
using System.Data.SQLite;
using System.Data;

namespace login
{
    /// <summary>
    /// Interaction logic for dangky.xaml
    /// </summary>
    public partial class dangky : Window
    {
        public const string dbcon = "Data Source = E:\\Code VS\\BTL_CSharp\\login.db";
        SQLiteConnection conn = new SQLiteConnection(dbcon);
        public dangky()
        {
            InitializeComponent();
        }

        public void ClearData()
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();

        }

        public bool isValid()
        {
            if (txt1.Text == String.Empty)
            {
                MessageBox.Show("Name is required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (txt2.Text == String.Empty)
            {
                MessageBox.Show("Age is required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (txt3.Text == String.Empty)
            {
                MessageBox.Show("Username is required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (txt4.Text == String.Empty)
            {
                MessageBox.Show("Password is required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (radio1.IsChecked == false && radio2.IsChecked == false)
            {
                MessageBox.Show("Gender is required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            String strGioiTinh;
            
            if (radio1.IsChecked == true)
                strGioiTinh = "Nam";
            else
            {
                strGioiTinh = "Nữ";
            }
            try
            {
                if (isValid())
                {
                    SQLiteCommand command = new SQLiteCommand("INSERT INTO login VALUES (@Username, @Password, @Name, @Age, @GioiTinh)");
                    command.CommandType = CommandType.Text;
                    command.Connection = conn;
                    command.Parameters.AddWithValue("@Username", txt3.Text);
                    command.Parameters.AddWithValue("@Password", txt4.Text);
                    command.Parameters.AddWithValue("@Name", txt1.Text);
                    command.Parameters.AddWithValue("@Age", txt2.Text);
                    command.Parameters.AddWithValue("@GioiTinh", strGioiTinh);
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Đăng ký thành công!", "Saved", MessageBoxButton.OK, MessageBoxImage.Information);
                    ClearData();                    
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
