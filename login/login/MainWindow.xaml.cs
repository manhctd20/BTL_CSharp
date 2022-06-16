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
using System.Data.SQLite;
using System.Data;

namespace login
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public const string dbcon = "Data Source = E:\\Code VS\\BTL_CSharp\\login.db";
        SQLiteConnection conn = new SQLiteConnection(dbcon);
        public MainWindow()
        {
            InitializeComponent();
        }
        public void ClearData()
        {
            username_txt.Clear();
            password_txt.Clear();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                String tk = username_txt.Text;
                String mk = password_txt.Password;
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM login WHERE Username = '" +tk+ "' and Password = '" +mk+ "' ",conn);
                conn.Open();
                command.Connection = conn;
                SQLiteDataReader reader = command.ExecuteReader();
                
                if (reader.Read()==true)
                {
                    ClearData();
                    hienthi strmain = new hienthi();
                    strmain.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai thông tin!", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                conn.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            dangky strmain = new dangky();
            strmain.ShowDialog();
        }
        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            var response = MessageBox.Show("Bạn thực sự muốn thoát?", "Thoát ...", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
            if (response == MessageBoxResult.No)
            {

            }
            else
            {
                Application.Current.Shutdown();
            }
        }
    }
}
