using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using SD = System.Data;



namespace Bookstore67
{
    /// <summary>
    /// Логика взаимодействия для store.xaml
    /// </summary>
    public partial class store : Window
    {
        public store()
        {
            InitializeComponent();
        }
        public MySqlConnection mycon;
        public MySqlCommand mycom;
        public string connect = "Server=localhost;Database=book_store;Uid=root;pwd=root;charset=utf8;";
        public SD.DataSet ds;


        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string MyConString =
           "SERVER=localhost;" +
           "DATABASE=book_store;" +
           "UID=root;" +
           "PASSWORD=root;";

            string sql = "SELECT * FROM `books` ORDER BY `books`.`Book_code` ASC";

            using (MySqlConnection connection = new MySqlConnection(MyConString))
            {
                connection.Open();
                using (MySqlCommand cmdSel = new MySqlCommand(sql, connection))
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);
                    da.Fill(dt);
                    dgv.ItemsSource = dt.DefaultView;
                }
                connection.Close();
            }


            var col = new DataGridTemplateColumn();
            string xaml = "<DataTemplate><Button Content=\"Купить\" /></DataTemplate>";
            var sr = new MemoryStream(Encoding.UTF8.GetBytes(xaml));
            var pc = new ParserContext();
            pc.XmlnsDictionary.Add("", "http://schemas.microsoft.com/winfx/2006/xaml/presentation");
            pc.XmlnsDictionary.Add("x", "http://schemas.microsoft.com/winfx/2006/xaml");
            DataTemplate datatemplate = (DataTemplate)XamlReader.Load(sr, pc);
            col.CellTemplate = datatemplate;

            dgv.Columns.Add(col);

        }




    }
}
