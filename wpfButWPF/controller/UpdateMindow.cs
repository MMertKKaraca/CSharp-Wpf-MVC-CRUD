using System;
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;

public interface IUpdateWindowControls{
    public void Update(string bitkiId,string bitkiAdi,string ortam,string _gozlemciler,string _durum);
}

public class UWControllers:IUpdateWindowControls{
    private UpdateFunction? Ufnc;
    public void Update(string bitkiId,string bitkiAdi,string ortam,string _gozlemciler,string _durum){
       
        Ufnc = new UpdateFunction();
        Ufnc.UpdateData(bitkiId,bitkiAdi,ortam,_gozlemciler,_durum);
        
      
    }
}