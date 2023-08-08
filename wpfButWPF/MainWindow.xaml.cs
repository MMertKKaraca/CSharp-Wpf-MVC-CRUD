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
using wpfBut.view;

namespace wpfBut
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MMControllers? MMcontroller;
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Insert_Btn(object sender,RoutedEventArgs e){
            InsertWindow win = new InsertWindow();
            win.Show();
        }
        public void Update_Btn(object sender,RoutedEventArgs e){
            DataRowView? selectedRow = dataT.SelectedItem as DataRowView;
            if(selectedRow != null) {
                string? bitkiId = selectedRow["bitkiId"].ToString();
                string? bitkiAdi = selectedRow["bitkiAdi"].ToString();
                string? ortam = selectedRow["ortam"].ToString();
                string? _gozlemciler = selectedRow["_gozlemciler"].ToString();
                string? _durum = selectedRow["_durum"].ToString();
                UpdateWindow win = new UpdateWindow(bitkiId,bitkiAdi,ortam,_gozlemciler,_durum);
                win.Show();
            }
            else{
                MessageBox.Show("Tablodan Update Edilecek Satır Seçilmedi!");
            }
            
        }
     
        public void Delete_Btn(object sender,RoutedEventArgs e){
            MMcontroller=new MMControllers();
            DataRowView? selectedRow = dataT.SelectedItem as DataRowView;
            if(selectedRow != null) {
                string str = selectedRow["bitkiId"].ToString();
                MMcontroller.Delete(str);

                DataTable dt = new DataTable();
                MMcontroller.SearchAll().Fill(dt);
                dataT.ItemsSource = dt.DefaultView;
            }
            else{
                MessageBox.Show("Tablodan Silinecek Satır Seçilmedi!");
            }
                  
        }
        public void SearchAll_Btn(object sender,RoutedEventArgs e){
            MMcontroller=new MMControllers();
            DataTable dt = new DataTable();
            MMcontroller.SearchAll().Fill(dt);
            dataT.ItemsSource = dt.DefaultView;
        }
        public void Search_Btn(object sender,RoutedEventArgs e){
            MMcontroller=new MMControllers();
            string str = T1.Text.ToString();

            DataTable dt = new DataTable();
            MMcontroller.Search(str).Fill(dt);
            dataT.ItemsSource = dt.DefaultView;
            
        }
    }
}
