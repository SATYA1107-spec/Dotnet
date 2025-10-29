using System;
using System.Data;
using Microsoft.Data.SqlClient;
class Execute_reader_demo
{                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           
    public static void Main(string[] args)
    {
        new Execute_reader_demo().SQL_connection();
    }
    public void SQL_connection()
    {
        SqlConnection sql = new SqlConnection("Server=Ayyapa\\SQLEXPRESS;Database=cus;Integrated Security=True;Encrypt=true;TrustServerCertificate=true;");
        sql.Open();
        SqlCommand cmd = new SqlCommand("select * from orders", sql);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            int sno = (int)reader[0];
            string name = (string)reader[1];
            double price = Convert.ToDouble(reader[2]);
            Console.WriteLine(sno + " " + name + " " + price);
        }
        sql.Close();
    }
}