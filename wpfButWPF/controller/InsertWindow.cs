using System;
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;

public interface IInsertWindowControls{
    public void Insert(string bitkiAdi,string ortam,string _gozlemciler,string _durum);
}

public class IWControllers:IInsertWindowControls{
    private InsertFunction? Ifnc;
    public void Insert(string bitkiAdi,string ortam,string _gozlemciler,string _durum){
       
        Ifnc = new InsertFunction();
        Ifnc.InsertData(bitkiAdi,ortam,_gozlemciler,_durum);
        
    }
}