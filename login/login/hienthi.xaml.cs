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
    /// Interaction logic for hienthi.xaml
    /// </summary>
    public partial class hienthi : Window
    {
        public const string dbcon = "Data Source = E:\\DBSQLite\\login.db";
        SQLiteConnection conn = new SQLiteConnection(dbcon);
        public hienthi()
        {
            InitializeComponent();
            LoadGrid();
        }

        public void LoadGrid()
        {
            SQLiteCommand command = new SQLiteCommand("Select * from hienthi");
            DataTable dt = new DataTable();
            conn.Open();
            command.Connection = conn;
            SQLiteDataReader reader = command.ExecuteReader();
            dt.Load(reader);
            conn.Close();
            datagrid.ItemsSource = dt.DefaultView;
        }

        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            Themdulieu strmain = new Themdulieu();
            strmain.Show();
            this.Close();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            Themdulieu strmain = new Themdulieu();
            strmain.Show();
            this.Close();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Themdulieu strmain = new Themdulieu();
            strmain.Show();
            this.Close();
        }
    }
}
