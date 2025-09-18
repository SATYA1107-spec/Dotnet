using System;
using System.Data;
using System.Data.SqlClient;

class Ado_demo
{
    public static void Main(string[] args)
    {
        new Ado_demo().SQL_connection();
    }
    public void SQL_connection()
    {
        SqlConnection sql = new SqlConnection("Server=Ayyapa\\SQLEXPRESS;Database=satya;Integrated Security=True;");
        sql.Open();
        SqlCommand cmd = new SqlCommand("insert into  accounts values (1,  'satya')", sql);
        cmd.ExecuteNonQuery();
        Console.WriteLine("success");
        sql.Close();
    }
}