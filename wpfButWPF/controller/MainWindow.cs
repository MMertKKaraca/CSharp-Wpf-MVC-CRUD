using System;
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;


public interface IMainWindowControls{
    public void Delete(string str);
    public SqlDataAdapter SearchAll();
    public SqlDataAdapter Search(string str);

}
public class MMControllers:IMainWindowControls{
    private  DataFunctions? functions;

    public void Delete(string str){
        functions = new DataFunctions();
        functions.DeleteData(str);
    }
    public SqlDataAdapter SearchAll(){
        functions = new DataFunctions();
        return functions.SearchAllData();
    }
    public SqlDataAdapter Search(string str){
        functions = new DataFunctions();
        return functions.SearchData(str);
    }
}
