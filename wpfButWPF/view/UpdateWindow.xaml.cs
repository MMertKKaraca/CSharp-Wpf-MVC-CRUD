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

    public partial class UpdateWindow : Window
    {
        private UWControllers? IWController;
        public UpdateWindow(string bitkiId,string bitkiAdi,string ortam,string _gozlemciler,string _durum)
        {
            InitializeComponent();
            this.bitkiId.Text = bitkiId;
            this.bitkiAdi.Text = bitkiAdi;
            this.ortam.Text = ortam;
            this._gozlemciler.Text = _gozlemciler;
            this._durum.Text = _durum;
        }
        public void Update_Data_Btn(object sender,RoutedEventArgs e){
            string bitkiIdData = bitkiId.Text;
            string bitkiAdiData = bitkiAdi.Text;
            string ortamData = ortam.Text;
            string _gozlemcilerData = _gozlemciler.Text;
            string _durumData = _durum.Text;

            if(bitkiAdiData != "" && ortamData != "" && _gozlemcilerData != "" && _durumData != ""){
                try{
                IWController = new UWControllers();
                IWController.Update(bitkiIdData,bitkiAdiData,ortamData,_gozlemcilerData,_durumData);
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
