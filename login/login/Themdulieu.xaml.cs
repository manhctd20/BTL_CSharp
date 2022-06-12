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
    /// Interaction logic for Themdulieu.xaml
    /// </summary>
    public partial class Themdulieu : Window
    {
        public const string dbcon = "Data Source = E:\\DBSQLite\\login.db";
        SQLiteConnection conn = new SQLiteConnection(dbcon);
        public Themdulieu()
        {
            InitializeComponent();
        }
        public void ClearData()
        {
            Name_txt.Clear();
            Date_txt.Clear();
            Type_txt.Clear();
            Size_txt.Clear();
            search_txt.Clear();
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
        }

        public bool isValid()
        {
            if (search_txt.Text == String.Empty)
            {
                MessageBox.Show("ID is required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            if (Name_txt.Text == String.Empty)
            {
                MessageBox.Show("Name is required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (Date_txt.Text == String.Empty)
            {
                MessageBox.Show("Date is required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (Type_txt.Text == String.Empty)
            {
                MessageBox.Show("Type is required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (Size_txt.Text == String.Empty)
            {
                MessageBox.Show("Size is required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }

        private void insertBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (isValid())
                {
                    SQLiteCommand command = new SQLiteCommand("INSERT INTO hienthi VALUES (@ID, @NAME, @DATE, @TYPE, @SIZE)");
                    command.CommandType = CommandType.Text;
                    command.Connection = conn;
                    command.Parameters.AddWithValue("@ID", search_txt.Text);
                    command.Parameters.AddWithValue("@NAME", Name_txt.Text);
                    command.Parameters.AddWithValue("@DATE", Date_txt.Text);
                    command.Parameters.AddWithValue("@TYPE", Type_txt.Text);
                    command.Parameters.AddWithValue("@SIZE", Size_txt.Text);
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                    LoadGrid();
                    MessageBox.Show("Successfully Inserted", "Saved", MessageBoxButton.OK, MessageBoxImage.Information);
                    ClearData();
                    hienthi strmain = new hienthi();
                    strmain.Show();
                    this.Close();
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(dbcon);
            conn.Open();
            SQLiteCommand command = new SQLiteCommand("DELETE FROM hienthi WHERE ID = " + search_txt.Text + "", conn);
            command.CommandType = CommandType.Text;
            try
            {               
                command.ExecuteNonQuery();
                MessageBox.Show("Record has been deleted", "Deleted", MessageBoxButton.OK, MessageBoxImage.Information);
                ClearData();
                hienthi strmain = new hienthi();
                strmain.Show();
                this.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Not Deleted" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(dbcon);
            conn.Open();
            SQLiteCommand command = new SQLiteCommand("update hienthi set NAME = '" + Name_txt.Text + "',DATE ='" + Date_txt.Text + "',TYPE = '" + Type_txt.Text + "',SIZE = '" + Size_txt.Text + "' WHERE ID = '" + search_txt.Text + "'", conn);
            command.CommandType = CommandType.Text;
            try
            {               
                command.ExecuteNonQuery();
                MessageBox.Show("Record has been updated", "Updated", MessageBoxButton.OK, MessageBoxImage.Information);
                hienthi strmain = new hienthi();
                strmain.Show();
                this.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                ClearData();
                LoadGrid();
            }
        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            hienthi strmain = new hienthi();
            strmain.Show();
        }
    }
}
