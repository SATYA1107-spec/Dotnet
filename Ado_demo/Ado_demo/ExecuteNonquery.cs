using Microsoft.Data.SqlClient;
using System;
using System.Data;
class Ado_demo
{
    public static void Main(string[] args)
    {
        new Ado_demo().SQL_connection();
    }
    public void SQL_connection()
    {
        SqlConnection sql = new SqlConnection(@"Server=Ayyapa\SQLEXPRESS;Database=cus;Integrated Security=True;Encrypt=true;TrustServerCertificate=true;");
        sql.Open();
        SqlCommand cmd = new SqlCommand("insert into orders values(4,'watch', 5000)", sql);
        int result = cmd.ExecuteNonQuery();
        Console.WriteLine($"{result} row(s) updated.");
        sql.Close();
    }
}