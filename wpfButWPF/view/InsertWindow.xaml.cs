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


namespace wpfBut.view
{

    public partial class InsertWindow : Window
    {
        private IWControllers? IWController;
        public InsertWindow()
        {
            InitializeComponent();
        }

        public void Insert_Data_Btn(object sender,RoutedEventArgs e){
            
            string bitkiAdiData = bitkiAdi.Text;
            string ortamData = ortam.Text;
            string _gozlemcilerData = _gozlemciler.Text;
            string _durumData = _durum.Text;
            if(bitkiAdiData != "" && ortamData != "" && _gozlemcilerData != "" && _durumData != ""){
                try{
                IWController = new IWControllers();
                IWController.Insert(bitkiAdiData,ortamData,_gozlemcilerData,_durumData);
                MessageBox.Show("Kayıt başarılı!");
                }
                catch{
                    MessageBox.Show("Kayıt yapılamadı!");
                }
            }
            else{
                MessageBox.Show("Boş Değerler");
            }

        }
    }

  
   
}
