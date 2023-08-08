using System;
using System.Windows;
using System.Data.SqlClient;

public interface IMainWindowModel{
    public void DeleteData(string str);
    public SqlDataAdapter SearchAllData();
    public SqlDataAdapter SearchData(string str);
}

public class DataFunctions:IMainWindowModel{
    static string connectionString ="Server=DESKTOP-5SIE434\\SQLEXPRESS;"+"Database=Okul;"+"Trusted_Connection=Yes;";
    SqlConnection dbcon;
    public void DeleteData(string str){
        dbcon = new SqlConnection(connectionString);
        dbcon.Open();
        SqlCommand dbcmd = dbcon.CreateCommand();
        string sql =$"Delete from Bitki where bitkiId = {str}";
        dbcmd.CommandText = sql;
        SqlDataReader reader = dbcmd.ExecuteReader();
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd=null;
        dbcon.Close();
        dbcon=null;
    }
    public SqlDataAdapter SearchAllData(){
        dbcon = new SqlConnection(connectionString);
        dbcon.Open();
        SqlCommand dbcmd = dbcon.CreateCommand();
        string sql ="Select * from Bitki";
        dbcmd.CommandText = sql;
        SqlDataAdapter reader = new SqlDataAdapter(dbcmd);
        return reader;
    }
    public SqlDataAdapter SearchData(string str){
        dbcon = new SqlConnection(connectionString);
        dbcon.Open();
        SqlCommand dbcmd = dbcon.CreateCommand();
        string sql =$"Select * from Bitki where bitkiId Like '%{str}%' or bitkiAdi Like '%{str}%' or ortam Like '%{str}%' or _gozlemciler Like '%{str}%' or _durum Like '%{str}%'";
        dbcmd.CommandText = sql;
        SqlDataAdapter reader = new SqlDataAdapter(dbcmd);
        return reader;
    }
}