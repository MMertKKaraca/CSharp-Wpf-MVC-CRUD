using System;
using System.Windows;
using System.Data.SqlClient;

public interface IUpdateWindowModel{
    public void UpdateData(string bitkiId,string bitkiAdi,string ortam,string _gozlemciler,string _durum);
    
}

public class UpdateFunction:IUpdateWindowModel{
    static string connectionString ="Server=DESKTOP-5SIE434\\SQLEXPRESS;"+"Database=Okul;"+"Trusted_Connection=Yes;";
    SqlConnection dbcon;
    public void UpdateData(string bitkiId,string bitkiAdi,string ortam,string _gozlemciler,string _durum){
        dbcon = new SqlConnection(connectionString);
        dbcon.Open();
        SqlCommand dbcmd = dbcon.CreateCommand();
        string sql =$"Update Bitki set bitkiAdi = '{bitkiAdi}', ortam ='{ortam}', _gozlemciler ='{_gozlemciler}', _durum ='{_durum}' where bitkiId = {bitkiId} ";
        dbcmd.CommandText = sql;
        SqlDataReader reader = dbcmd.ExecuteReader();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd=null;
        dbcon.Close();
        dbcon=null;
    }
}
