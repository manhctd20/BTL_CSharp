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
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace login
{
    /// <summary>
    /// Interaction logic for hienthi.xaml
    /// </summary>
    public partial class hienthi : Window
    {
        public const string dbcon = "Data Source = E:\\Code VS\\BTL_CSharp\\login.db";
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

        private void export_Click(object sender, RoutedEventArgs e)
        {
            string filePath = "";
            SaveFileDialog Dialog = new SaveFileDialog();

            Dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls ";

            if (Dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePath = Dialog.FileName;
            }

            if (string.IsNullOrEmpty(filePath))
            {
                System.Windows.MessageBox.Show("Đường dẫn báo cáo không hợp lệ");
                return;
            }
            try
            {
                using (ExcelPackage p = new ExcelPackage())
                {
                    p.Workbook.Properties.Author = "Team6";

                    p.Workbook.Properties.Title = "Demo";

                    p.Workbook.Worksheets.Add("Team6");

                    ExcelWorksheet ws = p.Workbook.Worksheets[1];

                    ws.Name = "Team6";

                    ws.Cells.Style.Font.Size = 11;

                    ws.Cells.Style.Font.Name = "Calibri";

                    string[] arrColumnsHeader =
                    {
                        "ID","NAME", "DATE", "TYPE", "SIZE"
                    };
                    var countColHeader = arrColumnsHeader.Count();

                    ws.Cells[1, 1].Value = "Thông tin ảnh";
                    ws.Cells[1, 1, 1, countColHeader].Merge = true;
                    //in đậm
                    ws.Cells[1, 1, 1, countColHeader].Style.Font.Bold = true;
                    ws.Cells[1, 1, 1, countColHeader].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                    int colIndex = 1;
                    int rowIndex = 2;

                    foreach (var item in arrColumnsHeader)
                    {
                        var Cell = ws.Cells[colIndex, rowIndex];

                        //gán giá trị
                        Cell.Value = item;

                        colIndex++;
                    }
                    List<napanh> dsanh = datagrid.ItemsSource.Cast<napanh>().ToList();
                    foreach (var item in dsanh)
                    {
                        colIndex = 1;

                        rowIndex++;

                        ws.Cells[rowIndex, colIndex++].Value = item.ID;

                        ws.Cells[rowIndex, colIndex++].Value = item.DATE.ToShortDateString();
                    }

                    Byte[] bin = p.GetAsByteArray();
                    File.WriteAllBytes(filePath, bin);
                }
                System.Windows.MessageBox.Show("Xuất file thành công!");
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Có lỗi khi lưu file");
            }
        }

        public class napanh
        {
            public int ID { get; set; }
            public string NAME { get; set; }
            public DateTime DATE { get; set; }
            public string TYPE { get; set; }
            public string SIZE { get; set; }
        }

        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            
            var response = System.Windows.MessageBox.Show("Bạn thực sự muốn đăng xuất?", "Thoát", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
            if (response == MessageBoxResult.No)
            {

            }
            else
            {
                this.Close();
            }
        }
    }
}
