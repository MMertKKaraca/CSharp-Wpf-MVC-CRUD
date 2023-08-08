using System;
using System.Windows;
using System.Data.SqlClient;

public interface IInsertWindowModel{
    public void InsertData(string bitkiAdi,string ortam,string _gozlemciler,string _durum);
    
}

public class InsertFunction:IInsertWindowModel{
    static string connectionString ="Server=DESKTOP-5SIE434\\SQLEXPRESS;"+"Database=Okul;"+"Trusted_Connection=Yes;";
    SqlConnection dbcon;
    public void InsertData(string bitkiAdi,string ortam,string _gozlemciler,string _durum){
        dbcon = new SqlConnection(connectionString);
        dbcon.Open();
        SqlCommand dbcmd = dbcon.CreateCommand();
        string sql =$"Insert into Bitki values ('{bitkiAdi}','{ortam}','{_gozlemciler}','{_durum}')";
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
